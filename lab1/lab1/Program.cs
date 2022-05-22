using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    internal class Program
    {

        public static bool sentinel = true;
        public static string readFile = "";
        public static string[] words;
        public static string[] lines;
        


        public static void readFromFile(string address)
        {
            int wordsCount = 0;
            readFile = File.ReadAllText(address);
            lines = readFile.Split("\n");

            for (int i = 0; i < lines.Length; i++)
            {
                words = lines[i].Split(" ");
                wordsCount = wordsCount + words.Length;
            }

            Console.Clear();
            Console.WriteLine("Number of Words: " + Convert.ToString(wordsCount));
        }

        public static IList<string> bubbleSort(string [] words)
        {
             IList<string> wordsList = new List<string>();
        Console.Clear();
            if (lines != null)
            {

                for (int i = 0; i < lines.Length; i++)
                {
                    words = lines[i].Split(" ");
                    for (int j = 0; j < words.Length; j++)
                    {
                        wordsList.Add(words[j]);
                    }


                }
                DateTime startTime = DateTime.Now;
                int startTimeMs = startTime.Millisecond;

                string temp = "";
                for (int i = 0; i < wordsList.Count - 1; i++)
                {
                    for (int j = i + 1; j < wordsList.Count; j++)
                    {
                        if (wordsList[j].CompareTo(wordsList[i]) > 0)
                        {
                            temp = wordsList[j];
                            wordsList[j] = wordsList[i];
                            wordsList[i] = temp;
                        }
                    }
                }
                DateTime endTime = DateTime.Now;
                int endTimeMs = endTime.Millisecond;

               /* foreach (string word in wordsList)
                {
                    Console.WriteLine(word);
                }*/
                Console.WriteLine("Execution Time: " + Convert.ToString(Math.Abs(endTimeMs - startTimeMs)) + " ms");
            }
            else
            {
                Console.WriteLine("There is not any words");
            }
            return wordsList;
        }

        static void Main(string[] args)
        {
            while (sentinel)
            {

                Console.WriteLine("1 - Import Words from File");
                Console.WriteLine("2 - Bubble Sort words");
                Console.WriteLine("3 - LINQ/Lambda sort words");
                Console.WriteLine("4 - Count the Distinct Words");
                Console.WriteLine("5 - Take the first 10 words");
                Console.WriteLine("6 - Get and display words that start with 'j' and display the count");
                Console.WriteLine("7 - Get and display words that end with 'd' and display the count");
                Console.WriteLine("8 - Get and display words that are greater than 4 characters long, and display the count");
                Console.WriteLine("9 - Get and display words that are less than 3 characters long and start with the letter 'a', and display the count");
                Console.WriteLine("x – Exit\n");
                Console.WriteLine("Select option");

                String option = Console.ReadLine();
                if ((option.Length == 1) && (option == "x" || option == "1" || option == "2" || option == "3"
                        || option == "4" || option == "5" || option == "6" || option == "7" || option == "8"
                        || option == "9"))
                {


                    if (option == "x")
                    {
                        sentinel = false;
                    }
                    else if (option == "1")
                    {
                        Console.WriteLine("Enter the file path:");
                        String address = Console.ReadLine();


                        try
                        {
                            readFromFile(address);
                                                   }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("File is not exist try again");
                        }


                    }
                    else if (option == "2")
                    {

                       bubbleSort(words);

                        /*List<string> wordsList = new List<string>();
                        Console.Clear();
                        if (lines != null)
                        {

                            for (int i = 0; i < lines.Length; i++)
                            {
                                words = lines[i].Split(" ");
                                for (int j = 0; j < words.Length; j++)
                                {
                                    wordsList.Add(words[j]);
                                }


                            }
                            DateTime startTime = DateTime.Now;
                            int startTimeMs = startTime.Millisecond;

                            string temp = "";
                            for (int i = 0; i < wordsList.Count - 1; i++)
                            {
                                for (int j = i + 1; j < wordsList.Count; j++)
                                {
                                    if (wordsList[j].CompareTo(wordsList[i]) > 0)
                                    {
                                        temp = wordsList[j];
                                        wordsList[j] = wordsList[i];
                                        wordsList[i] = temp;
                                    }
                                }
                            }
                            DateTime endTime = DateTime.Now;
                            int endTimeMs = endTime.Millisecond;

                            foreach (string word in wordsList)
                            {
                                Console.WriteLine(word);
                            }
                            Console.WriteLine("Execution Time: " + Convert.ToString(Math.Abs(endTimeMs - startTimeMs)) + " ms");
                        }
                        else
                        {
                            Console.WriteLine("There is not any words");
                        }
*/

                    }
                    else if (option == "3")
                    {


                        List<string> wordsList = new List<string>();
                        Console.Clear();
                        if (lines != null)
                        {

                            for (int i = 0; i < lines.Length; i++)
                            {
                                words = lines[i].Split(" ");
                                for (int j = 0; j < words.Length; j++)
                                {
                                    wordsList.Add(words[j]);
                                }


                            }
                            DateTime startTime = DateTime.Now;
                            int startTimeMs = startTime.Millisecond;
                            var sortedLINQwords = from w in wordsList orderby w ascending select w;
                            DateTime endTime = DateTime.Now;
                            int endTimeMs = endTime.Millisecond;

                            foreach (string word in sortedLINQwords)
                            {
                                Console.WriteLine(word);
                            }
                            Console.WriteLine("Execution Time: " + Convert.ToString(endTimeMs - startTimeMs) + " ms");
                        }
                        else
                        {
                            Console.WriteLine("There is not any words");
                        }


                    }

                    else if (option == "4")
                    {

                        int wordsCount = 0;
                        List<string> wordsList = new List<string>();
                        Console.Clear();
                        if (lines != null)
                        {

                            for (int i = 0; i < lines.Length; i++)
                            {
                                words = lines[i].Split(" ");
                                for (int j = 0; j < words.Length; j++)
                                {
                                    wordsList.Add(words[j]);
                                }


                            }
                            wordsList = wordsList.Distinct().ToList();

                            foreach (string word in wordsList)
                            {
                                Console.WriteLine(word);
                            }
                            Console.WriteLine("There are " + Convert.ToString(wordsList.Count - 1) + " distinct words in the file");
                        }
                        else
                        {
                            Console.WriteLine("There is not any words");
                        }


                    }

                    else if (option == "5")
                    {

                        int wordsCount = 0;

                        Console.Clear();
                        if (lines != null)
                        {

                            for (int i = 0; i < lines.Length; i++)
                            {
                                words = lines[i].Split(" ");
                                for (int j = 0; j < words.Length; j++)
                                {
                                    if (wordsCount < 10)
                                    {
                                        wordsCount++;
                                        Console.WriteLine(words[j]);
                                    }
                                }


                            }


                        }
                        else
                        {
                            Console.WriteLine("There is not any words");
                        }


                    }
                    else if (option == "6")
                    {

                        int wordsCount = 0;

                        Console.Clear();
                        if (lines != null)
                        {

                            for (int i = 0; i < lines.Length; i++)
                            {
                                words = lines[i].Split(" ");
                                for (int j = 0; j < words.Length; j++)
                                {
                                    if (words[j].Substring(0, 1) == "j")
                                    {
                                        wordsCount++;
                                        Console.WriteLine(words[j]);
                                    }
                                }


                            }
                            Console.WriteLine("There are " + Convert.ToString(wordsCount) + " words start with 'j'");

                        }
                        else
                        {
                            Console.WriteLine("There is not any words that start with 'j'");
                        }


                    }
                    else if (option == "7")
                    {

                        int wordsCount = 0;

                        Console.Clear();
                        if (lines != null)
                        {

                            for (int i = 0; i < lines.Length; i++)
                            {
                                words = lines[i].Split(" ");
                                string str = "";
                                for (int j = 0; j < words.Length; j++)
                                {
                                    str = words[j].Trim();
                                    if (str.EndsWith('d'))
                                    {

                                        wordsCount++;
                                        Console.WriteLine(str);
                                    }
                                }


                            }
                            Console.WriteLine("There are " + Convert.ToString(wordsCount) + " words end with 'd'");

                        }
                        else
                        {
                            Console.WriteLine("There is not any words that start with 'd'");
                        }


                    }
                    else if (option == "8")
                    {

                        int wordsCount = 0;

                        Console.Clear();
                        if (lines != null)
                        {

                            for (int i = 0; i < lines.Length; i++)
                            {
                                words = lines[i].Split(" ");
                                string str = "";
                                for (int j = 0; j < words.Length; j++)
                                {
                                    str = words[j].Trim();
                                    if (str.Length > 4)
                                    {

                                        wordsCount++;
                                        Console.WriteLine(str);
                                    }
                                }


                            }
                            Console.WriteLine("There are " + Convert.ToString(wordsCount) + " that thier lentghs are greater than 4");

                        }
                        else
                        {
                            Console.WriteLine("There is not any words in file");
                        }


                    }
                    else if (option == "9")
                    {

                        int wordsCount = 0;

                        Console.Clear();
                        if (lines != null)
                        {

                            for (int i = 0; i < lines.Length; i++)
                            {
                                words = lines[i].Split(" ");
                                string str = "";
                                for (int j = 0; j < words.Length; j++)
                                {
                                    str = words[j].Trim();
                                    if ((str.Length < 3) && (str.StartsWith("a")))
                                    {

                                        wordsCount++;
                                        Console.WriteLine(str);
                                    }
                                }


                            }
                            Console.WriteLine("There are " + Convert.ToString(wordsCount) + " that thier lentghs are less than 3 and start with 'a' ");

                        }
                        else
                        {
                            Console.WriteLine("There is not any words in file");
                        }


                    }

                }
                else
                {

                    Console.Clear();
                    Console.WriteLine("Select proper Option");
                }
            }

        }


    }


}
