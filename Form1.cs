﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klasaProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe");
        }

        private void buttonWord_Click(object sender, EventArgs e)
        {
            Process.Start("Word.exe");
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            Process.Start("Excel.exe");
        }

        private void buttonStartInfo_Click(object sender, EventArgs e)
        {
            
            ProcessStartInfo klasa;

            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");

            startInfo.WindowStyle = ProcessWindowStyle.Normal;

            startInfo.Arguments = "www.sser.hr";

            Process.Start(startInfo);
        }
    }
}
