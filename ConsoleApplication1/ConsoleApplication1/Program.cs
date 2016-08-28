﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms;

namespace ConsoleApplication1
{

        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.ShowDialog();

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string fileName;
                    fileName = dlg.FileName;
                    MessageBox.Show(fileName);
                }
            }
        }
}
