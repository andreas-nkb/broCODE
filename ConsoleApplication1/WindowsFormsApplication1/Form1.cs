using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public string Path { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Path = fbd.SelectedPath;
                Console.WriteLine(Path);
                this.DialogResult = DialogResult.OK;
                pathBox.Text = fbd.SelectedPath;

                SortBtn.Enabled = true;
                IdentifyBtn.Enabled = true;
                RenameBtn.Enabled = true;
                string a = "01";
                Console.WriteLine(Int32.Parse(a));

            }
        }

        public string GetPath()
        {
            return Path;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SortBtn.Enabled = false;
            IdentifyBtn.Enabled = false;
            RenameBtn.Enabled = false;
        }

        private void pathBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdentifyBtn_Click(object sender, EventArgs e)
        {
            SortBtn.Enabled = false;
            RenameBtn.Enabled = false;

            List <Tuple < string, string>> filesFound = Searcher.DirSearch(Path);

            for (int i = 0; i < filesFound.Count(); i++)
            {
                Console.WriteLine(filesFound[i].Item1);
                Console.WriteLine(filesFound[i].Item2);
            }

            /**{
                Searcher.Extract(f);
            }  */

            HashSet<string> h = Searcher.GetSet();
            Console.WriteLine(h.Count);

            SortBtn.Enabled = true;
            RenameBtn.Enabled = true;
            Close();
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {

        }

        private void RenameBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
