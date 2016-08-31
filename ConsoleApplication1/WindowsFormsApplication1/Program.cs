using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    static class Program
    {


        private static readonly Regex rx = new Regex
        (@"(.*?)\.S?(\d{1,2})E?(\d{2})\.(.*)", RegexOptions.IgnoreCase);

        public static HashSet<string> seriesList = new HashSet<string>();
        public static TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

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
                var mediaList = DirSearch(P);

                foreach (string f in mediaList)
                {
                    Extract(f);
                }

                foreach (string b in seriesList)
                {
                    Console.WriteLine(b);
                }
                Console.WriteLine(seriesList.Count);
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
                    .Select(Path.GetFileName)
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

        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }


        static void Extract(string text)
        {
            if (text.Contains("sample", StringComparison.OrdinalIgnoreCase) == true)
                return;

            MatchCollection matches = rx.Matches(text);
            foreach (Match match in matches)
            {   
                if (textInfo.ToTitleCase(match.Groups[1].ToString().Trim()).Contains("S0") == true )
                    return;
                else
                seriesList.Add(textInfo.ToTitleCase(match.Groups[1].ToString().Trim()));
            }

        }
    }
}
