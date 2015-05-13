using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibroLister {
  public class Libriloj {
    public Dictionary<string, EOWord> KnownWords;
    public int KnownDupes = 0;
    public string CurrentBookPath;

    public Dictionary<string, EOWord> RootWords, RootIrregulars;
    public Dictionary<string, EOWord> BookWords;

    public Dictionary<string, EOWord> BookProperWords;
    public int BookTotal, BookLength;
    //Chapters
    public string BookChapterPattern= "^Ĉapitro \\d?\\d\\.1$";
    public List<string> ChapterList;

    public class EOWord : IComparable<EOWord> {
      public string Root, Original, Chapter, RootEnding, ENTranslation, Definition;
      public bool Rooted, Compound, BookMatch, Irregular;
      public int Index = 0, Duplicates = 0;

      public EOWord() {
      }
      public EOWord(string Root, string Original) {
        this.Original = Original;
        this.Root = Root;
      }

      public int CompareTo(EOWord Other) {
        if (this.Index == Other.Index) return this.Root.CompareTo(Other.Root);
        return this.Index.CompareTo(Other.Index);
      }

      public EOWord Clone(EOWord MatchWord, bool Compound = false) {
        EOWord _Clone = (EOWord)this.MemberwiseClone();
        _Clone.Original = MatchWord.Original;
        _Clone.Compound = Compound;
        if (_Clone.RootEnding == "") _Clone.RootEnding = MatchWord.RootEnding;
        return _Clone;
      }
    }

    /// <summary>
    /// Reads the file of known words and stores them in the internal cache.
    /// </summary>
    /// <param name="FilePath"></param>
    /// <returns></returns>
    public bool ReadKnown(string FilePath) {
      if (!File.Exists(FilePath)) return false;
      var KnownFile = File.OpenText(FilePath);
      string Sentence, Buffer;
      EOWord[] NewWords;

      KnownWords = new Dictionary<string, EOWord>();
      KnownDupes = 0;
      while (!KnownFile.EndOfStream) {
        Sentence = Buffer = KnownFile.ReadLine();
        if (Buffer.IndexOf("\t") > 0) Buffer = Buffer.Substring(0, Buffer.IndexOf("\t"));
        NewWords = ParseRoot(Buffer.Split(' ')[0]);
        foreach (var NewWord in NewWords) {
          if (!KnownWords.ContainsKey(NewWord.Root)) {
            KnownWords.Add(NewWord.Root, NewWord);
          }
          else {
            KnownDupes++;
          }
        }
      }
      KnownFile.Close();
      return true;
    }

    private void AddVariants(string Root, HashSet<string> List) {
      foreach (string Prefix in Prefixes) {
        if (!List.Contains(Prefix + Root)) {
          List.Add(Prefix + Root);
        }
        else {
          KnownDupes++;
        }
      }
      foreach (string Postfix in Postfixes) {
        if (!List.Contains(Root + Postfix)) {
          List.Add(Root + Postfix);
        }
        else {
          KnownDupes++;
        }
      }
    }

    /// <summary>
    /// Reads a series of root words and checks them against affixes for consistency.
    /// </summary>
    /// <param name="FilePath"></param>
    /// <returns></returns>
    public bool FilterPIV(string ContentPath) {
      var PIVFile = File.OpenText(Path.Combine(ContentPath, "NPIV.txt"));
      string Buffer;
      var RootWords = new HashSet<string>();

      //Parse the PIV for irregular roots only
      while (!PIVFile.EndOfStream) {
        Buffer = PIVFile.ReadLine();
        if (Buffer.IndexOf("/") > 0) Buffer = Buffer.Substring(0, Buffer.IndexOf("/"));
        foreach (string Prefix in Prefixes) {
          if (Buffer.StartsWith(Prefix)) {
            RootWords.Add(Buffer);
            continue;
          }
        }
        foreach (string Postfix in Postfixes) {
          if (Buffer.EndsWith(Postfix)) {
            RootWords.Add(Buffer);
            continue;
          }
        }
      }
      PIVFile.Close();

      //Get the additional words
      string PIVPlusWords = File.ReadAllText(Path.Combine(ContentPath, "PIVPlus.txt"));

      //Write the conglomeration
      StreamWriter List = new StreamWriter(Path.Combine(ContentPath, "IrregularRoots.txt"), false, Encoding.UTF8);
      List.Write(PIVPlusWords);
      foreach (string Word in RootWords) {
        List.WriteLine(Word);
      }
      List.Close();
      return true;
    }

    /// <summary>
    /// Reads the book file and processes it.
    /// </summary>
    /// <param name="FilePath"></param>
    /// <returns></returns>
    public bool ReadBook(string FilePath = "") {
      if (FilePath == "") FilePath = CurrentBookPath;
      if (!File.Exists(FilePath)) return false;
      CurrentBookPath = FilePath;
      var BookFile = File.OpenText(FilePath);
      string Sentence, CurrentChapter = "";

      BookTotal = 0;
      BookLength = 0;     
      BookWords = new Dictionary<string, EOWord>();
      BookProperWords = new Dictionary<string, EOWord>();
      ChapterList = new List<string>();
      while (!BookFile.EndOfStream) {
        Sentence = BookFile.ReadLine();
        if (Regex.IsMatch(Sentence, BookChapterPattern)) {
          CurrentChapter = Sentence;
          if (!ChapterList.Contains(Sentence)) ChapterList.Add(Sentence);
          continue;
        }
        Sentence = AdjustCaps(Sentence);
        var Words = Regex.Matches(Sentence, "[a-zA-ZĉĈĝĜĥĤĵĴŝŜŭŬ-]+");
        foreach (Capture Word in Words) {
          BookTotal++;
          if (Word.Value.Length < 2) continue; //Ignore letter abbreviations and such
          if (Word.Value.All(Char.IsDigit)) continue; //Ignore numbers
          if (BookProperWords.Keys.Contains(Word.Value.ToLower()) || IsCapitalized(Word.Value)) {
            if (!BookProperWords.Keys.Contains(Word.Value))
              BookProperWords.Add(Word.Value, new EOWord(Word.Value.ToLower(), Word.Value));
            else
              BookProperWords[Word.Value].Duplicates++;
            continue;
          }
          EOWord[] _Words = ParseRoot(Word.Value);
          foreach (EOWord _Word in _Words) {
            _Word.Index = BookLength;
            _Word.Chapter = CurrentChapter;
            if (BookWords.ContainsKey(_Word.Root)) {
              BookWords[_Word.Root].Duplicates++;
              continue;
            }
            if (KnownWords.ContainsKey(_Word.Root)) {
              KnownWords[_Word.Root].BookMatch = true;
              continue;
            }
            else {
              BookWords.Add(_Word.Root, _Word);
            }
          }
        }
        BookLength += Sentence.Length;
      }
      BookFile.Close();
      return true;
    }

    /// <summary>
    /// Outputs the current book list to a file.
    /// </summary>
    /// <param name="BookPath"></param>
    public void WriteList(string BookPath, bool IncludeUnrooted, bool IncludeDefinitions, double SplitPercentage = 0) {
      string CurrentChapter = "", PartSpeech;
      string ListPath = BookPath.Replace(Path.GetExtension(BookPath), ".list.txt");
      StreamWriter ListFile = new StreamWriter(ListPath, false, Encoding.UTF8);

      var SortedList = BookWords.Values.ToArray<EOWord>();
      Array.Sort(SortedList);
      //Set up percentage chapters
      if (SplitPercentage > 0) {
        //Get the index divisor
        int SplitIndex = 0;
        SplitPercentage /= 100;
        foreach (EOWord Word in SortedList) {
          if (Word.Index >= (SplitIndex * SplitPercentage) * BookLength) {
            Word.Chapter = "{{Novĉapitro " + (SplitIndex + 1) + "}}";
            SplitIndex++;
          }
        }
      }

      foreach (EOWord Word in SortedList) {
        if ((Word.Chapter.Length > 0) && (Word.Chapter != CurrentChapter)) {
          ListFile.WriteLine(Word.Chapter);
          CurrentChapter = Word.Chapter;
        }
        //Perhaps skip unrooted words
        if (!IncludeUnrooted && !Word.Rooted) continue; 
        switch (Word.RootEnding) {
          case "o": PartSpeech = "noun"; break;
          case "a": PartSpeech = "adjective"; break;
          case "e": PartSpeech = "adverb"; break;
          case "i": PartSpeech = "verb"; break;
          default: PartSpeech = ""; break;
        }
        ListFile.WriteLine(Word.Root + Word.RootEnding + "\t" + ((IncludeDefinitions) ? Word.ENTranslation : "") + "\t" + PartSpeech);
      }
      ListFile.Close();
    }

    /// <summary>
    /// Writes the current book with percentage chapter markers.
    /// </summary>
    /// <param name="BookPath"></param>
    /// <returns></returns>
    public bool WriteBook(string BookPath, double SplitPercentage) {
      string NewPath = BookPath.Replace(Path.GetExtension(BookPath), ".chapters.txt");

      if (!File.Exists(BookPath)) return false;
      var BookFile = File.OpenText(BookPath);
      StreamWriter NewFile = new StreamWriter(NewPath, false, Encoding.UTF8);
      
      string Sentence;

      int SplitIndex = 0, CurrentLength = 0;
      SplitPercentage /= 100;

      while (!BookFile.EndOfStream) {
        if (CurrentLength >= (SplitIndex * SplitPercentage) * BookLength) {
          NewFile.WriteLine("\n{{Novĉapitro " + (SplitIndex + 1) + "}}\n");
          SplitIndex++;
        }
        Sentence = BookFile.ReadLine();
        NewFile.WriteLine(Sentence);
        CurrentLength += Sentence.Length;
      }
      BookFile.Close();
      NewFile.Close();
      return true;
    }

    /// <summary>
    /// Returns true if the first letter of the word is capitalized.
    /// </summary>
    /// <param name="Word"></param>
    /// <returns></returns>
    public bool IsCapitalized(string Word) {
      char Letter = Word[0];

      if (Letter >= 'A' && Letter <= 'Z') return true;
      if (Letter == 'Ĉ') return true;
      if (Letter == 'Ĝ') return true;
      if (Letter == 'Ĥ') return true;
      if (Letter == 'Ĵ') return true;
      if (Letter == 'Ŝ') return true;
      if (Letter == 'Ŭ') return true;
      return false;
    }

    /// <summary>
    /// Change first words in sentences to lowercase.
    /// </summary>
    /// <param name="Sentence"></param>
    /// <returns></returns>
    public string AdjustCaps(string Sentence) {
      var FirstWord = Regex.Matches(Sentence, "\\w+");
      if (FirstWord.Count == 0) return Sentence;
      Sentence = Sentence.Replace(FirstWord[0].Value, FirstWord[0].Value.ToLower());
      var FirstWords = Regex.Matches(Sentence, "[\\.:?!][\"”“']?\\s+[\"”“']?([A-ZĈĜĤĴŜŬ]\\w+)");
      if (FirstWords.Count == 0) return Sentence;
      foreach (Capture Word in FirstWords) {
        Sentence = Sentence.Replace(Word.Value, Word.Value.ToLower());
      }
      return Sentence;
    }

    private string[] Postfixes = { "aĉ", "ad", "aĵ", "an", "ar", "ĉj", "ebl", "ec", "eg", "ej", "el", "em", "end", "er", "estr", "et", 
                                   "io", "iĉ", "id", "ig", "iĝ", "il", "in", "ind", "ing", "ism", "ist", "nj", "obl", "on", "op", "uj", "ul", "um",
                                   "int", "ant", "ont", "it", "at", "ot" };
    private string[] Prefixes = { "duon", "malbon", "for", "al", "bo", "dis", "eks", "ek", "el", "fi", "ge", "mal", "mis", "pra", "re" };
    private string[] VerbEndings = { "is", "as", "os", "us", "i", "u" };
    private string[] SpeechEndings = { "o", "a", "e" };
    /// <summary>
    /// Parses an EO word and returns a word object.
    /// </summary>
    /// <param name="Word"></param>
    /// <returns></returns>
    public EOWord[] ParseRoot(string TextWord) {
      EOWord NewWord = new EOWord();
      EOWord[] Roots;
      string OriginalRoot;

      NewWord.Original = NewWord.Root = TextWord.ToLower();
      NewWord.Root = NewWord.Root.Replace("-", "");
      //Roots = LookupRoot(NewWord, false); if (Roots.Length > 0) return Roots;
      //Check for the case that this is an irregular root that doesn't require decomposition
      if (RootIrregulars.ContainsKey(NewWord.Root)) return new EOWord[] { RootIrregulars[NewWord.Root].Clone(NewWord) };
      //Accusative and plural
      NewWord.Root = NewWord.Root.TrimEnd('n').TrimEnd('j');
      //Roots = LookupRoot(NewWord, false); if (Roots.Length > 0) return Roots;
      if (RootIrregulars.ContainsKey(NewWord.Root)) return new EOWord[] { RootIrregulars[NewWord.Root].Clone(NewWord) };
      //Verbs
      foreach (string Ending in VerbEndings) {
        if (NewWord.Root.EndsWith(Ending)) {
          NewWord.Root = NewWord.Root.Substring(0, NewWord.Root.Length - Ending.Length);
          NewWord.RootEnding = "i";
          break;
        }
      }
      //Parts of speech
      if (NewWord.RootEnding != "i") {
        foreach (string Ending in SpeechEndings) {
          if (NewWord.Root.EndsWith(Ending)) {
            NewWord.Root = NewWord.Root.Substring(0, NewWord.Root.Length - Ending.Length);
            NewWord.RootEnding = Ending;
            break;
          }
        }
      }
      Roots = LookupRoot(NewWord, false); if (Roots.Length > 0) return Roots;
      OriginalRoot = NewWord.Root; //For trying scenarios

      //Remove affixes while checking against root list
      string WordCheck;
      do {
        WordCheck = NewWord.Root;
        foreach (string Prefix in Prefixes) {
          if (NewWord.Root == Prefix) {
            NewWord.Rooted = true;
            return new EOWord[] { NewWord };
          }
          if (NewWord.Root.StartsWith(Prefix)) {
            NewWord.Root = NewWord.Root.Substring(Prefix.Length);
            break;
          }
        }
        Roots = LookupRoot(NewWord, false); if (Roots.Length > 0) return Roots;
        foreach (string Postfix in Postfixes) {
          if (NewWord.Root == Postfix) {
            NewWord.Rooted = true;
            return new EOWord[] { NewWord };
          }
          if (NewWord.Root.EndsWith(Postfix)) {
            NewWord.Root = NewWord.Root.Substring(0, NewWord.Root.Length - Postfix.Length);
            break;
          }
        }
        Roots = LookupRoot(NewWord, false); if (Roots.Length > 0) return Roots;
        //Revert and try again in opposite direction
        NewWord.Root = WordCheck;
        foreach (string Postfix in Postfixes) {
          if (NewWord.Root.EndsWith(Postfix)) {
            NewWord.Root = NewWord.Root.Substring(0, NewWord.Root.Length - Postfix.Length);
            break;
          }
        }
        Roots = LookupRoot(NewWord, false); if (Roots.Length > 0) return Roots;
        foreach (string Prefix in Prefixes) {
          if (NewWord.Root.StartsWith(Prefix)) {
            NewWord.Root = NewWord.Root.Substring(Prefix.Length);
            break;
          }
        }
        Roots = LookupRoot(NewWord, false); if (Roots.Length > 0) return Roots;
      } while (WordCheck != NewWord.Root);
      //Try compound roots
      Roots = LookupRoot(NewWord); if (Roots.Length > 0) return Roots;
      //If none of that worked, try compound without endings
      NewWord.Root = OriginalRoot;
      Roots = LookupRoot(NewWord); if (Roots.Length > 0) return Roots;
      //No root could be found in the list
      return new EOWord[] { NewWord };
    }

    /// <summary>
    /// Returns a copy of a root from the root list, or 2 if it is discovered to be compound.
    /// </summary>
    /// <param name="Root"></param>
    /// <returns></returns>
    private EOWord[] LookupRoot(EOWord Word, bool CheckCompound = true) {
      if (RootWords.ContainsKey(Word.Root)) return new EOWord[] { RootWords[Word.Root].Clone(Word) };
      if (!CheckCompound) return new EOWord[] { };
      //Try for a compound word
      for (var i = 2; i < Word.Root.Length; i++) {
        if (RootWords.ContainsKey(Word.Root.Substring(0, i)) && RootWords.ContainsKey(Word.Root.Substring(i))) {
          return new EOWord[] { RootWords[Word.Root.Substring(0, i)].Clone(Word, true), RootWords[Word.Root.Substring(i)].Clone(Word, true) };
        }
        //Try with a 1 character offset if that letter is an 'o'
        if ((Word.Root[i] == 'o' || Word.Root[i] == 'a' || Word.Root[i] == 'e') && RootWords.ContainsKey(Word.Root.Substring(0, i)) && RootWords.ContainsKey(Word.Root.Substring(i + 1))) {
          return new EOWord[] { RootWords[Word.Root.Substring(0, i)].Clone(Word, true), RootWords[Word.Root.Substring(i + 1)].Clone(Word, true) };
        }
      }
      return new EOWord[] {};
    }

    /// <summary>
    /// Load the list of root words from REVO JSON document.
    /// </summary>
    /// <param name="FilePath"></param>
    public void ReadJSONRoots(string FilePath) {
      JObject JSON;

      RootWords = new Dictionary<string, EOWord>();
      RootIrregulars = new Dictionary<string, EOWord>();
      //Read the main roots file
      //JSON = JObject.Parse(File.ReadAllText(Path.Combine(FilePath, "dictionary.json")));
      using (StreamReader _File = File.OpenText(Path.Combine(FilePath, "dictionary.json")))
      using (JsonTextReader _Reader = new JsonTextReader(_File)) {
        JSON = (JObject)JToken.ReadFrom(_Reader);
      }
      foreach (JProperty RevoWord in JSON.Properties()) {
        dynamic RWord = RevoWord;
        if (RWord.Value.primary == true && !((string)RWord.Name).StartsWith("-")) {
          EOWord _Word = new EOWord();
          _Word.Root = RWord.Value.root;
          _Word.Original = RWord.Name;
          if (_Word.Original.Length == _Word.Root.Length) {
            _Word.Irregular = true;
            RootIrregulars.Add(_Word.Root, _Word);
          }
          else {
            _Word.RootEnding = _Word.Original.Substring(_Word.Original.Length - 1);
          }
          _Word.Rooted = true;
          if (RWord.Value.definitions.Count > 0 && RWord.Value.definitions[0].translations.en != null) {
            _Word.ENTranslation = RWord.Value.definitions[0].translations.en[0];
            _Word.Definition = RWord.Value.definitions[0]["primary definition"];
          }
          //_Word.Definition = 
          RootWords.Add(_Word.Root, _Word);
        }
      }
      //Read the user roots
      //var Roots = File.OpenText(Path.Combine(FilePath, "UserRoots.txt"));
      //while (!Roots.EndOfStream) {
      //  EOWord NewWord = ParseDictionaryRoot(Roots.ReadLine());
      //  if (!RootWords.ContainsKey(NewWord.Root)) RootWords.Add(NewWord.Root, NewWord);
      //}
      //Roots.Close();
    }

    /// <summary>
    /// Load the list of root words that should not be reduced.
    /// </summary>
    /// <param name="FilePath"></param>
    public void ReadRoots(string FilePath) {
      RootWords = new Dictionary<string, EOWord>();
      string WordLine;

      //Read the main roots file
      var Roots = File.OpenText(Path.Combine(FilePath, "NPIV.txt"));
      while (!Roots.EndOfStream) {
        WordLine = Roots.ReadLine();
        if (WordLine.Contains("/")) {
          EOWord NewWord = ParseDictionaryRoot(WordLine);
          if (!RootWords.ContainsKey(NewWord.Root)) RootWords.Add(NewWord.Root, NewWord);
        }
      }
      Roots.Close();
      //Read the user roots
      Roots = File.OpenText(Path.Combine(FilePath, "UserRoots.txt"));
      while (!Roots.EndOfStream) {
        EOWord NewWord = ParseDictionaryRoot(Roots.ReadLine());
        if (!RootWords.ContainsKey(NewWord.Root)) RootWords.Add(NewWord.Root, NewWord);
      }
      Roots.Close();
    }

    private EOWord ParseDictionaryRoot(string WordLine) {
      var Buffer = WordLine.ToLower().Split('\t');
      EOWord NewWord = new EOWord();

      NewWord.Rooted = true;
      if (Buffer[0].Contains('/')) {
        var SlashIndex = Buffer[0].IndexOf("/");
        NewWord.Root = Buffer[0].Substring(0, SlashIndex);
        NewWord.RootEnding = Buffer[0].Substring(SlashIndex + 1);
        NewWord.Original = Buffer[0];
      }
      else {
        NewWord.Original = Buffer[0];
        NewWord.Root = Buffer[0];
      }
      //Add definition if we have one
      if (Buffer.Length > 1) NewWord.ENTranslation = Buffer[1];
      return NewWord;
    }
  }  
}
