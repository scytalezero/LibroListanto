using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroLister {
  public partial class MainForm : Form {
    public MainForm() {
      InitializeComponent();
    }

    private Libriloj Librilo = new Libriloj();
    private string KnownWordsPath, BookPath;
    private Libriloj.EOWord[] CurrentList;

    private void MainForm_Load(object sender, EventArgs e) {
      ShowKnown.MouseClick += ShowKnown_MouseClick;
      //Librilo.ReadRoots(Path.Combine(Application.StartupPath, "Content"));
      Librilo.ReadJSONRoots(Path.Combine(Application.StartupPath, "Content"));
      if (Properties.Settings.Default.LastKnownWords.Length > 0)
        SetKnownFile(Properties.Settings.Default.LastKnownWords);
      //if (Properties.Settings.Default.LastBook.Length > 0)
      //  BookPath = Properties.Settings.Default.LastBook;

      //KnownFile.BackColor = Color.Yellow;
      //Librilo.FilterPIV(Path.Combine(Application.StartupPath, "Content"));
      //KnownFile.BackColor = Color.LightGreen;

      SplitPercentageValue.Items.Add(3);
      SplitPercentageValue.Items.Add(5);
      SplitPercentageValue.Items.Add(7);
      SplitPercentageValue.Items.Add(10);
      SplitPercentageValue.Items.Add(15);
      SplitPercentageValue.Items.Add(20);
      SplitPercentageValue.SelectedItem = 5;
    }

    private void SetKnownFile(string FilePath) {
      KnownWordsPath = FilePath;
      Properties.Settings.Default.LastKnownWords = FilePath;
      Properties.Settings.Default.Save();
      KnownFile.Text = Path.GetFileName(FilePath);
      if (Librilo.ReadKnown(KnownWordsPath)) {
        KnownFile.BackColor = Color.LightGreen;
        KnownCount.Text = Librilo.KnownWords.Count.ToString();
        KnownDupeCount.Text = Librilo.KnownDupes.ToString();
        int Unrooted = 0, Compound = 0;
        foreach (Libriloj.EOWord Word in Librilo.KnownWords.Values) {
          if (!Word.Rooted) Unrooted++;
          if (Word.Compound) Compound++;
        }
        KnownUnrooted.Text = Unrooted.ToString();
        KnownCompound.Text = Compound.ToString();
        ShowKnown_MouseClick(null, null);
      }
      else {
        KnownFile.BackColor = Color.Red;
      }
    }

    private void SetBookFile(string FilePath) {
      BookPath = FilePath;
      Properties.Settings.Default.LastBook = FilePath;
      Properties.Settings.Default.Save();
      TXTFile.Text = Path.GetFileName(FilePath);
      if (Librilo.ReadBook(BookPath)) {
        TXTFile.BackColor = Color.LightGreen;
        BookProper.Text = Librilo.BookProperWords.Keys.Count.ToString();
        int Unrooted=0, Compound=0, Duplicates=0;
        foreach (Libriloj.EOWord Word in Librilo.BookWords.Values) {
          if (!Word.Rooted) Unrooted++;
          if (Word.Compound) Compound++;
          Duplicates += Word.Duplicates;
        }
        BookUnrooted.Text = Unrooted.ToString();
        BookCompound.Text = Compound.ToString();
        BookDupes.Text = Duplicates.ToString();
        int Known = 0;
        foreach (Libriloj.EOWord Word in Librilo.KnownWords.Values) {
          if (Word.BookMatch) Known++;
        }
        BookTotal.Text = (Librilo.BookWords.Count + Known).ToString();
        BookKnown.Text = Known.ToString();
        ShowList_Click(null, null);
      }
      else {
        TXTFile.BackColor = Color.Red;
      }
    }

    private void KnownFile_Click(object sender, EventArgs e) {
      openFileDialog.InitialDirectory = Application.StartupPath;
      if (openFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
      SetKnownFile(openFileDialog.FileName);
    }

    private void TXTFile_Click(object sender, EventArgs e) {
      openFileDialog.InitialDirectory = Application.StartupPath;
      if (openFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
      SetBookFile(openFileDialog.FileName);
    }

    /// <summary>
    /// Display a list of words in the listbox for the user.
    /// </summary>
    /// <param name="Words"></param>
    /// <param name="Label"></param>
    private void ShowWords(Libriloj.EOWord[] Words = null, string Label = null) {
      if (Words == null) {
        Words = CurrentList;
      }
      else {
        Array.Sort(Words); 
        CurrentList = Words;
      }
      if (Label != null) WordListLabel.Text = Label + " (" + Words.Length + ")";
      WordList.Items.Clear();
      foreach (var Word in Words) {
        if (FilterUnrooted.Checked && Word.Rooted) continue;
        if (FilterText.Text.Length > 0 && 
          !Word.Original.Contains(FilterText.Text)) continue;
        var _Item = new ListViewItem(Word.Root + "/" + Word.RootEnding);
        _Item.SubItems.Add(Word.Original);
        _Item.SubItems.Add(Word.ENTranslation);
        _Item.SubItems.Add(Word.Duplicates.ToString());
        if (!Word.Rooted) _Item.BackColor = Color.Yellow;
        if (Word.Compound) _Item.ForeColor = Color.Blue;
        WordList.Items.Add(_Item);
        
      }
    }

    void ShowKnown_MouseClick(object sender, MouseEventArgs e) {
      ShowWords(Librilo.KnownWords.Values.ToArray<Libriloj.EOWord>(), "Known Words");
    }

    private void ShowList_Click(object sender, EventArgs e) {
      ShowWords(Librilo.BookWords.Values.ToArray<Libriloj.EOWord>(), "Book List");
    }

    private void ShowProper_Click(object sender, EventArgs e) {
      ShowWords(Librilo.BookProperWords.Values.ToArray<Libriloj.EOWord>(), "Proper Words");
    }

    private void ShowIrregular_Click(object sender, EventArgs e) {
      ShowWords(Librilo.RootIrregulars.Values.ToArray<Libriloj.EOWord>(), "Irregular Roots");
    }

    private void WriteList_Click(object sender, EventArgs e) {
      WriteList.Enabled = false;
      Librilo.WriteList(BookPath, WriteIncludeRooted.Checked, WriteIncludeDefinitions.Checked, (int)SplitPercentageValue.SelectedItem);
      WriteList.Enabled = true;
    }

    private void textBox1_TextChanged(object sender, EventArgs e) {
      ShowWords();
    }

    private void FilterUnrooted_CheckedChanged(object sender, EventArgs e) {
      ShowWords();
    }

    private void WriteBookBreaks_Click(object sender, EventArgs e) {
      Librilo.WriteBook(BookPath, (int)SplitPercentageValue.SelectedItem);
    }

  }
}
