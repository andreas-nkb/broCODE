using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            Application.Run(form1);
            if (form1.DialogResult == DialogResult.OK)
            {
                string P = form1.GetPath();
                Console.WriteLine(P);
                var mediaList= DirSearch(P);
                foreach (string f in mediaList)
                {
                    Console.WriteLine(f);
                }
            }
            else
            {
                Console.WriteLine("Error!!!!");
            }
        }


        static List<string> DirSearch(string sDir)
        {
            var filesFound = new List<string>();
            try
            {
                string[] extensions = { ".mkv", ".mp4" };
                foreach (string file in Directory.EnumerateFiles(sDir, "*.*", SearchOption.AllDirectories)
                   .Where(s => extensions.Any(ext => ext == Path.GetExtension(s))))
                {
                    
                    filesFound.Add(file);
                }

                return filesFound;
            }
            
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
                return filesFound;
            }
            
        }
    }
}
