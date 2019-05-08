using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman
{
    class wordFetcher
    {
        public static string FetchWord(int language)
        {
            String downloadString = "";
            System.Net.WebClient client = new System.Net.WebClient();
            if (language == 0)
            {
                downloadString = client.DownloadString("https://pastebin.com/raw/S05WH6qd");
            }
            else if (language == 1)
            {
                downloadString = client.DownloadString("https://www.randomlists.com/data/words.json");
            }
            else if (language == 2)
            {
                downloadString = client.DownloadString("https://pastebin.com/raw/7bfExzJH");
            }

            string[] Words = jasonToArray(downloadString);

            Random rnd = new Random();
            int index = rnd.Next(Words.Length);
            var word = Words[index];
            //WriteFile(Words);

            Console.WriteLine("The Word is:" + word);

            return word;
        }

        public static string[] jasonToArray(string downloadWordList)
        {
            downloadWordList = downloadWordList.Replace("\"", "");
            downloadWordList = downloadWordList.Replace("{", "");
            downloadWordList = downloadWordList.Replace("[", "");
            downloadWordList = downloadWordList.Replace("}", "");
            downloadWordList = downloadWordList.Replace("]", "");
            downloadWordList = downloadWordList.Replace(":", "\n");
            string[] Words = downloadWordList.Split('\n', ',');
            return Words;
        }
        /*public static void WriteFile(string[] Words, int language)
        {
            if (language == 0)
            {
                using (StreamWriter writer = new StreamWriter("/home/dleh/WordListDK.txt"))
                {
                    for (int i = 0; i < Words.Length; i++)
                    {
                        writer.WriteLine(Words[i]);
                    }
                }
            }
            else if (language == 1)
            {
                using (StreamWriter writer = new StreamWriter("/home/dleh/WordListEN.txt"))
                {
                    for (int i = 0; i < Words.Length; i++)
                    {
                        writer.WriteLine(Words[i]);
                    }
                }
            }
            else if (language == 2)
            {
                using (StreamWriter writer = new StreamWriter("/home/dleh/WordListDE.txt"))
                {
                    for (int i = 0; i < Words.Length; i++)
                    {
                        writer.WriteLine(Words[i]);
                    }
                }
            }
        }*/
    }
}
