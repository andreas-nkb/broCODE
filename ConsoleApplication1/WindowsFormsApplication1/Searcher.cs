using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{


    public static class Searcher
    {

        private static readonly Regex rx = new Regex
        (@"(.*?)(:?- |- S| S|.S|\d{4}\.S)(\d{1,2})(:?X|E)(\d{2})(:?.| )(.*)", RegexOptions.IgnoreCase);

        public static HashSet<string> seriesList = new HashSet<string>();
        public static TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        public static StringBuilder sb = new StringBuilder();

        public static HashSet<string> GetSet()
        {
            return seriesList;
        }

        public static List<Tuple<string, string>> DirSearch(string sDir)
        {
            var filesFound = new List<Tuple<string, string>>();
            try
            {
                string[] extensions = { ".mkv", ".mp4", "avi" };
                foreach (string path in Directory.EnumerateFiles(sDir, "*.*", SearchOption.AllDirectories)
                    .Where(s => extensions.Any(ext => ext == Path.GetExtension(s))))
                {
                    string file = Path.GetFileNameWithoutExtension(path);
                    filesFound.Add(new Tuple<string, string>(file, path));
                }
   
                Console.WriteLine(filesFound.Count);
                return filesFound;
            }

            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
                return null;
            }

        }

                public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }


        public static void Extract(string text)
        {
            if (text.Contains("sample", StringComparison.OrdinalIgnoreCase) == true)
                return;

            MatchCollection matches = rx.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1] + " | " + match.Groups[3] + " | " + match.Groups[5] + " | " + match.Groups[7]);
                sb.Clear();
                sb.Append(textInfo.ToTitleCase(match.Groups[1].ToString().Trim()));
                sb.Replace(".", " ");
                Console.WriteLine(sb);
                seriesList.Add(sb.ToString());
            }
        }

        public class Season
        {
            public string Name { get; set; }
            public int Number { get; set; }
            public List<Episode> Episode;
            public Season(string name, int number)
            {
                Name = name;
                Number = number;
            }
            //Other properties, methods, events...
        }

        public class Episode
        {
            public int Number { get; set; }
            public string FilePath { get; set; }
            public Episode(int number, string filepath)
            {
                Number = number;
                FilePath = filepath;
            }
            //Other properties, methods, events...
        }

        /**
        StringBuilder sb = new StringBuilder();
        int count = 0;
        foreach (string text in mediaList)
        {
            if (text.Contains("sample", StringComparison.OrdinalIgnoreCase) == true)
                return;

            MatchCollection matches = rx.Matches(text);
            foreach (Match match in matches)
            {
               // Console.WriteLine(match.Groups[1] + " | " + match.Groups[3] + " | " + match.Groups[5] + " | " + match.Groups[7]);
              //   sb.Append(textInfo.ToTitleCase(match.Groups[1].ToString().Trim()));
              //  sb.Replace(".", " ");
                seriesList.Add(textInfo.ToTitleCase(match.Groups[1].ToString().Trim()));
               // sb.Clear();
            }
        }
        Console.WriteLine(seriesList.Count);
        foreach (string f in seriesList)
        {
            count++;
            Console.WriteLine(f);
        }
        Console.WriteLine(count);
*/


    }

    
}
