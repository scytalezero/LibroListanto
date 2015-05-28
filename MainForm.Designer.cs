namespace LibroListanto {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.label1 = new System.Windows.Forms.Label();
      this.KnownFile = new System.Windows.Forms.Label();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.ShowIrregular = new System.Windows.Forms.Button();
      this.KnownCompound = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.KnownUnrooted = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.ShowKnown = new System.Windows.Forms.Button();
      this.KnownDupeCount = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.KnownCount = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.WordListLabel = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.SplitPercentageValue = new System.Windows.Forms.ComboBox();
      this.BookCompound = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.BookUnrooted = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.ShowProper = new System.Windows.Forms.Button();
      this.ShowList = new System.Windows.Forms.Button();
      this.BookProper = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.BookKnown = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.BookDupes = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.BookTotal = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.SplitChapter = new System.Windows.Forms.RadioButton();
      this.SplitPercentage = new System.Windows.Forms.RadioButton();
      this.TXTFile = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.WriteList = new System.Windows.Forms.Button();
      this.WordList = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.FilterText = new System.Windows.Forms.TextBox();
      this.FilterUnrooted = new System.Windows.Forms.CheckBox();
      this.WriteIncludeRooted = new System.Windows.Forms.CheckBox();
      this.WriteBookBreaks = new System.Windows.Forms.Button();
      this.WriteIncludeDefinitions = new System.Windows.Forms.CheckBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(6, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "TSV File:";
      // 
      // KnownFile
      // 
      this.KnownFile.BackColor = System.Drawing.Color.Khaki;
      this.KnownFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.KnownFile.Location = new System.Drawing.Point(71, 26);
      this.KnownFile.Name = "KnownFile";
      this.KnownFile.Size = new System.Drawing.Size(277, 22);
      this.KnownFile.TabIndex = 1;
      this.KnownFile.Tag = "Click to choose your file of known words.";
      this.KnownFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.KnownFile.Click += new System.EventHandler(this.KnownFile_Click);
      this.KnownFile.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
      this.KnownFile.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.ShowIrregular);
      this.groupBox1.Controls.Add(this.KnownCompound);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.KnownUnrooted);
      this.groupBox1.Controls.Add(this.label14);
      this.groupBox1.Controls.Add(this.ShowKnown);
      this.groupBox1.Controls.Add(this.KnownDupeCount);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.KnownCount);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.KnownFile);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(360, 111);
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "1) Known Words";
      // 
      // ShowIrregular
      // 
      this.ShowIrregular.Enabled = false;
      this.ShowIrregular.Location = new System.Drawing.Point(265, 82);
      this.ShowIrregular.Name = "ShowIrregular";
      this.ShowIrregular.Size = new System.Drawing.Size(83, 23);
      this.ShowIrregular.TabIndex = 11;
      this.ShowIrregular.Tag = "Show the list of irregular roots you already know.";
      this.ShowIrregular.Text = "Show Irregular";
      this.ShowIrregular.UseVisualStyleBackColor = true;
      this.ShowIrregular.Click += new System.EventHandler(this.ShowIrregular_Click);
      this.ShowIrregular.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
      this.ShowIrregular.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
      // 
      // KnownCompound
      // 
      this.KnownCompound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.KnownCompound.ForeColor = System.Drawing.SystemColors.Highlight;
      this.KnownCompound.Location = new System.Drawing.Point(212, 87);
      this.KnownCompound.Name = "KnownCompound";
      this.KnownCompound.Size = new System.Drawing.Size(50, 13);
      this.KnownCompound.TabIndex = 10;
      this.KnownCompound.Text = "0";
      this.KnownCompound.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(146, 87);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(58, 13);
      this.label9.TabIndex = 9;
      this.label9.Text = "Compound";
      // 
      // KnownUnrooted
      // 
      this.KnownUnrooted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.KnownUnrooted.ForeColor = System.Drawing.SystemColors.Highlight;
      this.KnownUnrooted.Location = new System.Drawing.Point(57, 87);
      this.KnownUnrooted.Name = "KnownUnrooted";
      this.KnownUnrooted.Size = new System.Drawing.Size(50, 13);
      this.KnownUnrooted.TabIndex = 8;
      this.KnownUnrooted.Text = "0";
      this.KnownUnrooted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.Location = new System.Drawing.Point(6, 87);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(51, 13);
      this.label14.TabIndex = 7;
      this.label14.Text = "Unrooted";
      // 
      // ShowKnown
      // 
      this.ShowKnown.Enabled = false;
      this.ShowKnown.Location = new System.Drawing.Point(265, 59);
      this.ShowKnown.Name = "ShowKnown";
      this.ShowKnown.Size = new System.Drawing.Size(83, 23);
      this.ShowKnown.TabIndex = 6;
      this.ShowKnown.Tag = "Show the list of words you already know.";
      this.ShowKnown.Text = "Show Known";
      this.ShowKnown.UseVisualStyleBackColor = true;
      this.ShowKnown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowKnown_MouseClick);
      this.ShowKnown.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
      this.ShowKnown.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
      // 
      // KnownDupeCount
      // 
      this.KnownDupeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.KnownDupeCount.ForeColor = System.Drawing.SystemColors.Highlight;
      this.KnownDupeCount.Location = new System.Drawing.Point(212, 64);
      this.KnownDupeCount.Name = "KnownDupeCount";
      this.KnownDupeCount.Size = new System.Drawing.Size(50, 13);
      this.KnownDupeCount.TabIndex = 5;
      this.KnownDupeCount.Text = "0";
      this.KnownDupeCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(146, 64);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(60, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "Duplicates:";
      // 
      // KnownCount
      // 
      this.KnownCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.KnownCount.ForeColor = System.Drawing.SystemColors.Highlight;
      this.KnownCount.Location = new System.Drawing.Point(57, 64);
      this.KnownCount.Name = "KnownCount";
      this.KnownCount.Size = new System.Drawing.Size(50, 13);
      this.KnownCount.TabIndex = 3;
      this.KnownCount.Text = "0";
      this.KnownCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(6, 64);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(43, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Known:";
      // 
      // WordListLabel
      // 
      this.WordListLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.WordListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.WordListLabel.Location = new System.Drawing.Point(378, 12);
      this.WordListLabel.Name = "WordListLabel";
      this.WordListLabel.Size = new System.Drawing.Size(262, 23);
      this.WordListLabel.TabIndex = 7;
      this.WordListLabel.Text = "Empty";
      this.WordListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.SplitPercentageValue);
      this.groupBox2.Controls.Add(this.BookCompound);
      this.groupBox2.Controls.Add(this.label7);
      this.groupBox2.Controls.Add(this.BookUnrooted);
      this.groupBox2.Controls.Add(this.label11);
      this.groupBox2.Controls.Add(this.ShowProper);
      this.groupBox2.Controls.Add(this.ShowList);
      this.groupBox2.Controls.Add(this.BookProper);
      this.groupBox2.Controls.Add(this.label10);
      this.groupBox2.Controls.Add(this.BookKnown);
      this.groupBox2.Controls.Add(this.label12);
      this.groupBox2.Controls.Add(this.BookDupes);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.BookTotal);
      this.groupBox2.Controls.Add(this.label8);
      this.groupBox2.Controls.Add(this.SplitChapter);
      this.groupBox2.Controls.Add(this.SplitPercentage);
      this.groupBox2.Controls.Add(this.TXTFile);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.Location = new System.Drawing.Point(12, 129);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(360, 144);
      this.groupBox2.TabIndex = 8;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "2) Source Book";
      // 
      // SplitPercentageValue
      // 
      this.SplitPercentageValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.SplitPercentageValue.Enabled = false;
      this.SplitPercentageValue.FormattingEnabled = true;
      this.SplitPercentageValue.Location = new System.Drawing.Point(118, 40);
      this.SplitPercentageValue.Name = "SplitPercentageValue";
      this.SplitPercentageValue.Size = new System.Drawing.Size(35, 21);
      this.SplitPercentageValue.TabIndex = 20;
      this.SplitPercentageValue.Tag = "Choose the percentage used to split the book into sections for your study list.";
      this.SplitPercentageValue.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
      this.SplitPercentageValue.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
      // 
      // BookCompound
      // 
      this.BookCompound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BookCompound.ForeColor = System.Drawing.SystemColors.Highlight;
      this.BookCompound.Location = new System.Drawing.Point(210, 111);
      this.BookCompound.Name = "BookCompound";
      this.BookCompound.Size = new System.Drawing.Size(50, 13);
      this.BookCompound.TabIndex = 19;
      this.BookCompound.Text = "0";
      this.BookCompound.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(146, 111);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(58, 13);
      this.label7.TabIndex = 18;
      this.label7.Text = "Compound";
      // 
      // BookUnrooted
      // 
      this.BookUnrooted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BookUnrooted.ForeColor = System.Drawing.SystemColors.Highlight;
      this.BookUnrooted.Location = new System.Drawing.Point(55, 111);
      this.BookUnrooted.Name = "BookUnrooted";
      this.BookUnrooted.Size = new System.Drawing.Size(50, 13);
      this.BookUnrooted.TabIndex = 17;
      this.BookUnrooted.Text = "0";
      this.BookUnrooted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(6, 111);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(51, 13);
      this.label11.TabIndex = 16;
      this.label11.Text = "Unrooted";
      // 
      // ShowProper
      // 
      this.ShowProper.Enabled = false;
      this.ShowProper.Location = new System.Drawing.Point(265, 89);
      this.ShowProper.Name = "ShowProper";
      this.ShowProper.Size = new System.Drawing.Size(83, 23);
      this.ShowProper.TabIndex = 15;
      this.ShowProper.Tag = "Show the words from your book suspected to be proper nouns.";
      this.ShowProper.Text = "Show Proper";
      this.ShowProper.UseVisualStyleBackColor = true;
      this.ShowProper.Click += new System.EventHandler(this.ShowProper_Click);
      this.ShowProper.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
      this.ShowProper.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
      // 
      // ShowList
      // 
      this.ShowList.Enabled = false;
      this.ShowList.Location = new System.Drawing.Point(265, 66);
      this.ShowList.Name = "ShowList";
      this.ShowList.Size = new System.Drawing.Size(83, 23);
      this.ShowList.TabIndex = 14;
      this.ShowList.Tag = "Show the list of words found in your book.";
      this.ShowList.Text = "Show List";
      this.ShowList.UseVisualStyleBackColor = true;
      this.ShowList.Click += new System.EventHandler(this.ShowList_Click);
      this.ShowList.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
      this.ShowList.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
      // 
      // BookProper
      // 
      this.BookProper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BookProper.ForeColor = System.Drawing.SystemColors.Highlight;
      this.BookProper.Location = new System.Drawing.Point(210, 89);
      this.BookProper.Name = "BookProper";
      this.BookProper.Size = new System.Drawing.Size(50, 13);
      this.BookProper.TabIndex = 13;
      this.BookProper.Text = "0";
      this.BookProper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(146, 89);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(41, 13);
      this.label10.TabIndex = 12;
      this.label10.Text = "Proper:";
      // 
      // BookKnown
      // 
      this.BookKnown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BookKnown.ForeColor = System.Drawing.SystemColors.Highlight;
      this.BookKnown.Location = new System.Drawing.Point(55, 89);
      this.BookKnown.Name = "BookKnown";
      this.BookKnown.Size = new System.Drawing.Size(50, 13);
      this.BookKnown.TabIndex = 11;
      this.BookKnown.Text = "0";
      this.BookKnown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(6, 89);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(43, 13);
      this.label12.TabIndex = 10;
      this.label12.Text = "Known:";
      // 
      // BookDupes
      // 
      this.BookDupes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BookDupes.ForeColor = System.Drawing.SystemColors.Highlight;
      this.BookDupes.Location = new System.Drawing.Point(210, 66);
      this.BookDupes.Name = "BookDupes";
      this.BookDupes.Size = new System.Drawing.Size(50, 13);
      this.BookDupes.TabIndex = 9;
      this.BookDupes.Text = "0";
      this.BookDupes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(146, 66);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(60, 13);
      this.label6.TabIndex = 8;
      this.label6.Text = "Duplicates:";
      // 
      // BookTotal
      // 
      this.BookTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BookTotal.ForeColor = System.Drawing.SystemColors.Highlight;
      this.BookTotal.Location = new System.Drawing.Point(55, 66);
      this.BookTotal.Name = "BookTotal";
      this.BookTotal.Size = new System.Drawing.Size(50, 13);
      this.BookTotal.TabIndex = 7;
      this.BookTotal.Text = "0";
      this.BookTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(6, 66);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(34, 13);
      this.label8.TabIndex = 6;
      this.label8.Text = "Total:";
      // 
      // SplitChapter
      // 
      this.SplitChapter.AutoSize = true;
      this.SplitChapter.Enabled = false;
      this.SplitChapter.Location = new System.Drawing.Point(175, 41);
      this.SplitChapter.Name = "SplitChapter";
      this.SplitChapter.Size = new System.Drawing.Size(85, 17);
      this.SplitChapter.TabIndex = 5;
      this.SplitChapter.TabStop = true;
      this.SplitChapter.Tag = "Click to find chapters in your book which can separate your study list.";
      this.SplitChapter.Text = "Chapter Split";
      this.SplitChapter.UseVisualStyleBackColor = true;
      this.SplitChapter.Click += new System.EventHandler(this.SplitChapter_Click);
      this.SplitChapter.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
      this.SplitChapter.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
      // 
      // SplitPercentage
      // 
      this.SplitPercentage.AutoSize = true;
      this.SplitPercentage.Checked = true;
      this.SplitPercentage.Enabled = false;
      this.SplitPercentage.Location = new System.Drawing.Point(9, 41);
      this.SplitPercentage.Name = "SplitPercentage";
      this.SplitPercentage.Size = new System.Drawing.Size(103, 17);
      this.SplitPercentage.TabIndex = 4;
      this.SplitPercentage.TabStop = true;
      this.SplitPercentage.Tag = "Separates your study list by percentages of the book.";
      this.SplitPercentage.Text = "Percentage Split";
      this.SplitPercentage.UseVisualStyleBackColor = true;
      this.SplitPercentage.Click += new System.EventHandler(this.SplitPercentage_Click);
      this.SplitPercentage.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
      this.SplitPercentage.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
      // 
      // TXTFile
      // 
      this.TXTFile.BackColor = System.Drawing.Color.Khaki;
      this.TXTFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TXTFile.Location = new System.Drawing.Point(71, 16);
      this.TXTFile.Name = "TXTFile";
      this.TXTFile.Size = new System.Drawing.Size(277, 22);
      this.TXTFile.TabIndex = 3;
      this.TXTFile.Tag = "Click to choose the book from which you want to generate a vocabulary list.";
      this.TXTFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.TXTFile.Click += new System.EventHandler(this.TXTFile_Click);
      this.TXTFile.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
      this.TXTFile.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(6, 21);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(50, 13);
      this.label5.TabIndex = 2;
      this.label5.Text = "TXT File:";
      // 
      // WriteList
      // 
      this.WriteList.Enabled = false;
      this.WriteList.Location = new System.Drawing.Point(9, 19);
      this.WriteList.Name = "WriteList";
      this.WriteList.Size = new System.Drawing.Size(75, 31);
      this.WriteList.TabIndex = 9;
      this.WriteList.Tag = "Create your study list as [book file name].list.txt.";
      this.WriteList.Text = "Create List";
      this.WriteList.UseVisualStyleBackColor = true;
      this.WriteList.Click += new System.EventHandler(this.WriteList_Click);
      this.WriteList.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
      this.WriteList.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
      // 
      // WordList
      // 
      this.WordList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
      this.WordList.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.WordList.FullRowSelect = true;
      this.WordList.Location = new System.Drawing.Point(378, 38);
      this.WordList.Name = "WordList";
      this.WordList.Size = new System.Drawing.Size(515, 297);
      this.WordList.TabIndex = 10;
      this.WordList.Tag = "The list shows compound roots in blue and unrooted words with a yellow background" +
    ".";
      this.WordList.UseCompatibleStateImageBehavior = false;
      this.WordList.View = System.Windows.Forms.View.Details;
      this.WordList.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
      this.WordList.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Root";
      this.columnHeader1.Width = 130;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Original";
      this.columnHeader2.Width = 130;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Translation";
      this.columnHeader3.Width = 130;
      // 
      // columnHeader4
      // 
      this.columnHeader4.Text = "Duplicates";
      this.columnHeader4.Width = 100;
      // 
      // FilterText
      // 
      this.FilterText.Location = new System.Drawing.Point(647, 12);
      this.FilterText.Name = "FilterText";
      this.FilterText.Size = new System.Drawing.Size(170, 20);
      this.FilterText.TabIndex = 11;
      this.FilterText.Tag = "Enter a search string to filter the currently displayed word list.";
      this.FilterText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      this.FilterText.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
      this.FilterText.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
      // 
      // FilterUnrooted
      // 
      this.FilterUnrooted.AutoSize = true;
      this.FilterUnrooted.Location = new System.Drawing.Point(823, 15);
      this.FilterUnrooted.Name = "FilterUnrooted";
      this.FilterUnrooted.Size = new System.Drawing.Size(70, 17);
      this.FilterUnrooted.TabIndex = 12;
      this.FilterUnrooted.Tag = "Check to show only unrooted words from the current list.";
      this.FilterUnrooted.Text = "Unrooted";
      this.FilterUnrooted.UseVisualStyleBackColor = true;
      this.FilterUnrooted.CheckedChanged += new System.EventHandler(this.FilterUnrooted_CheckedChanged);
      this.FilterUnrooted.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
      this.FilterUnrooted.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
      // 
      // WriteIncludeRooted
      // 
      this.WriteIncludeRooted.AutoSize = true;
      this.WriteIncludeRooted.Enabled = false;
      this.WriteIncludeRooted.Location = new System.Drawing.Point(91, 19);
      this.WriteIncludeRooted.Name = "WriteIncludeRooted";
      this.WriteIncludeRooted.Size = new System.Drawing.Size(106, 17);
      this.WriteIncludeRooted.TabIndex = 13;
      this.WriteIncludeRooted.Tag = "Include words that could not be verified in the root list.";
      this.WriteIncludeRooted.Text = "Include unrooted";
      this.WriteIncludeRooted.UseVisualStyleBackColor = true;
      this.WriteIncludeRooted.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
      this.WriteIncludeRooted.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
      // 
      // WriteBookBreaks
      // 
      this.WriteBookBreaks.Enabled = false;
      this.WriteBookBreaks.Location = new System.Drawing.Point(246, 19);
      this.WriteBookBreaks.Name = "WriteBookBreaks";
      this.WriteBookBreaks.Size = new System.Drawing.Size(108, 31);
      this.WriteBookBreaks.TabIndex = 14;
      this.WriteBookBreaks.Tag = "Copy your book file with generated chapters based on the percentage split to [boo" +
    "k file name].chapters.txt..";
      this.WriteBookBreaks.Text = "Write Book Breaks";
      this.WriteBookBreaks.UseVisualStyleBackColor = true;
      this.WriteBookBreaks.Click += new System.EventHandler(this.WriteBookBreaks_Click);
      this.WriteBookBreaks.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
      this.WriteBookBreaks.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
      // 
      // WriteIncludeDefinitions
      // 
      this.WriteIncludeDefinitions.AutoSize = true;
      this.WriteIncludeDefinitions.Enabled = false;
      this.WriteIncludeDefinitions.Location = new System.Drawing.Point(91, 33);
      this.WriteIncludeDefinitions.Name = "WriteIncludeDefinitions";
      this.WriteIncludeDefinitions.Size = new System.Drawing.Size(111, 17);
      this.WriteIncludeDefinitions.TabIndex = 15;
      this.WriteIncludeDefinitions.Tag = "For Memrise, you typically will not want definitions in your list. Memrise will a" +
    "dd them for you.";
      this.WriteIncludeDefinitions.Text = "Include definitions";
      this.WriteIncludeDefinitions.UseVisualStyleBackColor = true;
      this.WriteIncludeDefinitions.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
      this.WriteIncludeDefinitions.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.WriteList);
      this.groupBox3.Controls.Add(this.WriteIncludeDefinitions);
      this.groupBox3.Controls.Add(this.WriteIncludeRooted);
      this.groupBox3.Controls.Add(this.WriteBookBreaks);
      this.groupBox3.Location = new System.Drawing.Point(12, 279);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(360, 56);
      this.groupBox3.TabIndex = 16;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "3) Write List";
      // 
      // statusStrip
      // 
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
      this.statusStrip.Location = new System.Drawing.Point(0, 341);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new System.Drawing.Size(905, 22);
      this.statusStrip.TabIndex = 17;
      this.statusStrip.Text = "statusStrip1";
      // 
      // toolStripStatus
      // 
      this.toolStripStatus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.toolStripStatus.Name = "toolStripStatus";
      this.toolStripStatus.Size = new System.Drawing.Size(890, 17);
      this.toolStripStatus.Spring = true;
      this.toolStripStatus.Text = "Information tips appear here when you mouseover controls.";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(905, 363);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.FilterUnrooted);
      this.Controls.Add(this.FilterText);
      this.Controls.Add(this.WordList);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.WordListLabel);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "MainForm";
      this.Text = "LibroListanto";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label KnownFile;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label WordListLabel;
    private System.Windows.Forms.Label KnownDupeCount;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label KnownCount;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button ShowKnown;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label TXTFile;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label BookProper;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label BookKnown;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label BookDupes;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label BookTotal;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.RadioButton SplitChapter;
    private System.Windows.Forms.RadioButton SplitPercentage;
    private System.Windows.Forms.Button ShowProper;
    private System.Windows.Forms.Button ShowList;
    private System.Windows.Forms.Button WriteList;
    private System.Windows.Forms.Label BookCompound;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label BookUnrooted;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.ListView WordList;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.Label KnownCompound;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label KnownUnrooted;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.TextBox FilterText;
    private System.Windows.Forms.Button ShowIrregular;
    private System.Windows.Forms.CheckBox FilterUnrooted;
    private System.Windows.Forms.CheckBox WriteIncludeRooted;
    private System.Windows.Forms.ComboBox SplitPercentageValue;
    private System.Windows.Forms.Button WriteBookBreaks;
    private System.Windows.Forms.CheckBox WriteIncludeDefinitions;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
  }
}

