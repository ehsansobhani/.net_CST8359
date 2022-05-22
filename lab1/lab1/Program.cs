using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LabOne
{
    internal class Program
    {

        public static bool sentinel = true;
        public static string readFile = "";
        public static string[] words;
        public static string[] lines;
        public static IList<string> wordList = new List<string>();
        


        public static IList<string> readFromFile(string address)
        {
            int wordsCount = 0;
            IList<string> wordsList = new List<string>();
            readFile = File.ReadAllText(address);
            lines = readFile.Split("\n");

            for (int i = 0; i < lines.Length; i++)
            {
                words = lines[i].Split(" ");
                wordsCount = wordsCount + words.Length;
                for(int j = 0; j < words.Length; j++)
                {
                    wordsList.Add(words[j].Trim());
                }
            }

            Console.Clear();
            Console.WriteLine("Number of Words: " + Convert.ToString(wordsCount));
            return wordsList; 
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


        public static IList<string> takeFirstTenWords(string[] words)
        {
            int wordsCount = 0;
            IList<string> wordsList = new List<string>();
            


            Console.Clear();
            if (lines != null)
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    words = lines[i].Split(" ");
                    wordsCount = wordsCount + words.Length;
                    for (int j = 0; j < words.Length; j++)
                    {
                        wordsList.Add(words[j]);
                    }
                }
                
                wordsList = (from w in wordsList select w).Take(10).ToList();

                foreach (string word in wordsList)
                {
                    Console.WriteLine(word);
                }

            }
            else
            {
                Console.WriteLine("There is not any words");
            }

            return wordsList;  
        }

        public static IList<string> linqSort(string[] words)
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
                var sortedLINQwords = from w in wordsList orderby w ascending select w;
                DateTime endTime = DateTime.Now;
                int endTimeMs = endTime.Millisecond;

                /*foreach (string word in sortedLINQwords)
                {
                    Console.WriteLine(word);
                }*/
               
                Console.WriteLine("Execution Time: " + Convert.ToString(endTimeMs - startTimeMs) + " ms");
            }
            else
            {
                Console.WriteLine("There is not any words");
            }
            return wordsList;
        }

        public static IList<string> distictWords(string[] words)
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
                        wordsList.Add(words[j].Trim());
                    }


                }
                   wordsList = wordsList.Distinct().ToList();
              
                /*foreach (string word in wordsList)
                {
                    Console.WriteLine(word);
                }*/
                Console.WriteLine("There are " + Convert.ToString(wordsList.Count ) + " distinct words in the file");
            }
            else
            {
                Console.WriteLine("There is not any words");
            }
            return wordsList;
        }


        public static IList<string> startWithJ(string [] words)
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
                        wordsList.Add(words[j].Trim());
                    }


                }
                
                wordsList = wordsList.Where(w => w.StartsWith('j') ).ToList();
                Console.WriteLine("There are " + Convert.ToString(wordsList.Count) + " words start with 'j'");
                foreach (string word in wordsList)
                {
                    Console.WriteLine (word);
                }
                              

            }
            else
            {
                Console.WriteLine("There is not any words that start with 'j'");
            }

            return wordsList;
        }

        public static IList<string> endsWithD(string[] words)
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
                        wordsList.Add(words[j].Trim());
                    }


                }

                wordsList = wordsList.Where(w => w.EndsWith('d')).ToList();
                Console.WriteLine("There are " + Convert.ToString(wordsList.Count) + " words end with 'd'");
                foreach (string word in wordsList)
                {
                    Console.WriteLine(word);
                }


            }
            else
            {
                Console.WriteLine("There are not any words that end with 'd'");
            }

            return wordsList;
        }

        public static IList<string> haveMoreThan4Char(string[] words)
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
                        wordsList.Add(words[j].Trim());
                    }


                }

                wordsList = wordsList.Where(w => w.Length > 4).ToList();
                Console.WriteLine("There are " + Convert.ToString(wordsList.Count) + " words that have more than 4 characters");
                foreach (string word in wordsList)
                {
                    Console.WriteLine(word);
                }


            }
            else
            {
                Console.WriteLine("There are not any words that have more than 4 characters");
            }

            return wordsList;
        }

        public static IList<string> haveLessThan3CharStartWithA(string[] words)
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
                        wordsList.Add(words[j].Trim());
                    }


                }

                wordsList = wordsList.Where(w => w.Length <3 && w.StartsWith('a')).ToList();
                Console.WriteLine("There are " + Convert.ToString(wordsList.Count) + " words that have less than 3 characters and start with 'a'");
                foreach (string word in wordsList)
                {
                    Console.WriteLine(word);
                }


            }
            else
            {
                Console.WriteLine("There are not any words that have less than 3 characters and start with 'a' ");
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
                           wordList = readFromFile(address);
                                                   }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("File is not exist try again");
                        }


                    }
                    else if (option == "2")
                    {

                        wordList = bubbleSort(words);   

                    }
                    else if (option == "3")
                    {
                        wordList = linqSort(words);

                    }

                    else if (option == "4")
                    {
                        wordList = distictWords(words); 


                    }

                    else if (option == "5")
                    {
                        wordList = takeFirstTenWords(words);


                    }
                    else if (option == "6")
                    {
                        wordList = startWithJ(words);

                    }
                    else if (option == "7")
                    {
                        wordList = endsWithD(words);
                    }
                    else if (option == "8")
                    {
                        wordList = haveMoreThan4Char(words);
                        
                    }
                    else if (option == "9")
                    {
                        wordList = haveLessThan3CharStartWithA(words);
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
