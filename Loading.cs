﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroListanto {
  public partial class Loading : Form {
    public Libriloj libriloj;

    public Loading() {
      InitializeComponent();
    }

    private void Loading_Load(object sender, EventArgs e) {

    }

    private void Loading_Activated(object sender, EventArgs e) {
      Application.DoEvents();
      libriloj.ReadJSONRoots(Path.Combine(Application.StartupPath, "Content"));
      this.Close();
    }
  }
}
