using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroListanto {
  public partial class ChaptersForm : Form {
    public Libriloj Librilo;

    public ChaptersForm() {
      InitializeComponent();
    }

    private void TestButton_Click(object sender, EventArgs e) {
      ChapterList.Items.Clear();
      Librilo.ReadBook();
      if (Librilo.ChapterList == null || Librilo.ChapterList.Count == 0) {
        ChapterList.Items.Add("NO MATCHES");
        return;
      }
      if (!Librilo.ChapterPatterns.Contains(Librilo.BookChapterPattern)) Librilo.ChapterPatterns.Add(Librilo.BookChapterPattern);
      foreach (string Chapter in Librilo.ChapterList) {
        ChapterList.Items.Add(Chapter);
      }
    }

    private void ChapterPattern_TextChanged(object sender, EventArgs e) {
      Librilo.BookChapterPattern = ChapterPattern.Text;
    }

    private void ChaptersForm_Shown(object sender, EventArgs e) {
      foreach (string _Pattern in Librilo.ChapterPatterns) {
        ChapterPattern.Items.Add(_Pattern);
      }
      ChapterPattern.Text = Librilo.BookChapterPattern;
    }
  }
}
