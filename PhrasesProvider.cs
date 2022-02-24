using System;
using System.Configuration;
using System.IO;
using System.Linq;

namespace TeaTime
{
    public static class PhrasesProvider
    {
        public static string GetNextPhrase()
        {
            try {
                string fileName = ConfigurationManager.AppSettings["phrasesFileName"];
                Random rnd = new Random(DateTime.Now.Millisecond);

                using (TextReader tr = new StreamReader(fileName)) {
                    string allText = tr.ReadToEnd();
                    tr.Close();
                    string[] lines = allText.Split('\n').Select(n => n.Trim()).ToArray();
                    int idx = rnd.Next(0, lines.Length - 1);
                    return lines[idx];
                }
            }
            catch (Exception ex)
            {

                return "Close yourself!";
            }
        }
    }
}
