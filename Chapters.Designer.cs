namespace LibroListanto {
  partial class ChaptersForm {
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
      this.TestButton = new System.Windows.Forms.Button();
      this.ChapterList = new System.Windows.Forms.ListBox();
      this.ChapterPattern = new System.Windows.Forms.ComboBox();
      this.AcceptButton = new System.Windows.Forms.Button();
      this.CancelButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(76, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Chapter regex:";
      // 
      // TestButton
      // 
      this.TestButton.Location = new System.Drawing.Point(369, 3);
      this.TestButton.Name = "TestButton";
      this.TestButton.Size = new System.Drawing.Size(75, 23);
      this.TestButton.TabIndex = 2;
      this.TestButton.Text = "Test";
      this.TestButton.UseVisualStyleBackColor = true;
      this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
      // 
      // ChapterList
      // 
      this.ChapterList.FormattingEnabled = true;
      this.ChapterList.Location = new System.Drawing.Point(5, 30);
      this.ChapterList.Name = "ChapterList";
      this.ChapterList.Size = new System.Drawing.Size(439, 225);
      this.ChapterList.TabIndex = 3;
      // 
      // ChapterPattern
      // 
      this.ChapterPattern.FormattingEnabled = true;
      this.ChapterPattern.Location = new System.Drawing.Point(96, 5);
      this.ChapterPattern.Name = "ChapterPattern";
      this.ChapterPattern.Size = new System.Drawing.Size(266, 21);
      this.ChapterPattern.TabIndex = 4;
      this.ChapterPattern.TextChanged += new System.EventHandler(this.ChapterPattern_TextChanged);
      // 
      // AcceptButton
      // 
      this.AcceptButton.Location = new System.Drawing.Point(230, 261);
      this.AcceptButton.Name = "AcceptButton";
      this.AcceptButton.Size = new System.Drawing.Size(214, 26);
      this.AcceptButton.TabIndex = 5;
      this.AcceptButton.Text = "Accept";
      this.AcceptButton.UseVisualStyleBackColor = true;
      this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
      // 
      // CancelButton
      // 
      this.CancelButton.Location = new System.Drawing.Point(5, 261);
      this.CancelButton.Name = "CancelButton";
      this.CancelButton.Size = new System.Drawing.Size(219, 26);
      this.CancelButton.TabIndex = 6;
      this.CancelButton.Text = "Cancel";
      this.CancelButton.UseVisualStyleBackColor = true;
      this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
      // 
      // ChaptersForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(450, 293);
      this.ControlBox = false;
      this.Controls.Add(this.CancelButton);
      this.Controls.Add(this.AcceptButton);
      this.Controls.Add(this.ChapterPattern);
      this.Controls.Add(this.ChapterList);
      this.Controls.Add(this.TestButton);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ChaptersForm";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Chapters";
      this.Shown += new System.EventHandler(this.ChaptersForm_Shown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button TestButton;
    private System.Windows.Forms.ListBox ChapterList;
    private System.Windows.Forms.ComboBox ChapterPattern;
    private System.Windows.Forms.Button AcceptButton;
    private System.Windows.Forms.Button CancelButton;
  }
}