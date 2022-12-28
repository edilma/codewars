using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAlignJustify
{
    class Program
    {
        static void Main(string[] args)
        {
            string paragraph = "Viva la consentida a los que van a vivir";
            //List<string> wordsLine = (paragraph.Split().ToList());
         




            //int letters = wordsLine.Select(x => x.Length).Sum();
           string testDistri = Justify2(paragraph, 12);
           Console.WriteLine(testDistri);
            // Console.WriteLine(MinNumberLines(wordsLine, 10));
            Console.ReadLine();




        }
        public static string Justify(string str, int len)
        {
            // create an array of words in the paragraph
            List<string> words = str.Split(' ').ToList();
            // create the string to generate the answer
            StringBuilder justPara = new StringBuilder();

            // control if the whole list of words is being processed
            bool isFinish = false;


            while (!isFinish)
            {
                // do append the last word if there is only one and finish
                if (words.Count() <= 1)
                {

                    justPara.Append(words[0]);
                    isFinish = true;
                }
                else
                {
                    //currentWord is the current word being process
                    int currentWord = 0;
                    List<string> wordsinLine = new List<string>();
                    //Console.WriteLine("the number of words in paragraph are {0}", words.Count());
                    // int lines = 0;
                    int newlineLenght = 0;
                    while (currentWord < words.Count - 1)
                    {

                        if (newlineLenght <= len)
                        {
                            wordsinLine.Add(words[currentWord]);
                            words.RemoveAt(0);
                            Console.WriteLine("the number of words in the line are {0}", wordsinLine.Count());
                            //currentWord++;
                        }
                        else
                        {
                            // string newRenglon = DistributeSpaces(wordsinLine, len);
                            string newRenglon = String.Join(" ", wordsinLine);
                            Console.WriteLine(newRenglon);
                            justPara.Append(newRenglon);

                            justPara.Append('\n');
                            wordsinLine.Clear();

                        }
                        newlineLenght += words[currentWord].Length + 1;


                        /*
                         * 
                    
                        if (lines < 2)
                        {
                            wordsinLine.Add(words[currentWord]);
                            words.Remove(words[currentWord]);
                            currentWord++;
                            
                        }
                        else
                        {
                            string newRenglon = DistributeSpaces(wordsinLine, len);
                            finalParagraph.Append(newRenglon);
                            
                            finalParagraph.Append('\n');
                            wordsinLine.Clear();
                            currentWord++;
                        }
                        lines = MinNumberLines(wordsinLine, len);
                        */
                    };

                }

            }
            return justPara.ToString();






        }
        // this function distribute the spaces in lines that are not last one
        // the words need to be equal or less than needed to fill the line 
        // working 
        public static string DistributeSpaces(List<string> wordsLine, int len)
        {
            //<calculateTotals>
            // totalLetters is how many letters in totals 
            int totalLetters = wordsLine.Select(x => x.Length).Sum();

            // numberOfWords is how many words
            int numberOfWords = wordsLine.Count;
            // minimum number of spaces needed.  Last word doesn't need
            int minNumberSpaces = numberOfWords - 1;
            int spacesLeft = len - totalLetters - minNumberSpaces;
            //</calculateTotals>

            //if totalletters 

            if (spacesLeft == 0)
            {
                return String.Join("-", wordsLine);
            }
            else
            {
                int i = 0;
                do
                {
                    wordsLine[i] = wordsLine + "-";
                    spacesLeft--;
                } while (spacesLeft > 0);
                return String.Join(" ", wordsLine);

            }


        }
        // return how many lines are needed for the words in the list.  
        public static int MinNumberLines(List<string> words, int len)
        {
            // totalLetters is how many letters in totals 
            int totalLetters = words.Select(x => x.Length).Sum();
            Console.WriteLine("total letters in the list are: {0}", totalLetters);
            // numberOfWords is how many words
            int numberOfWords = words.Count;
            // minimum number of spaces needed.  Last word doesn't need
            int minNumberSpaces = numberOfWords - 1;

            int minNumberofLines = (totalLetters + minNumberSpaces) / len;

            return minNumberofLines;
        }

        public static string Justify2(string str, int len)
        {
            StringBuilder finalParagraph = new StringBuilder();
            List<string> words = str.Split(' ').ToList();
            Queue<string> wordsQueu = new Queue<string>();
            int lineSize = 0;
            List<string> lineWords = new List<string>();
            foreach (string word in words)
            {
                Console.WriteLine(word);
                wordsQueu.Enqueue(word);
                
            }
           // bool isFinished = false;
            string nextWord = wordsQueu.Peek();
            while (nextWord !=string.Empty)
            {
                lineSize = lineSize + nextWord.Length + 1;
                if (lineSize <= len)
                {
                    Console.WriteLine($"We are processing {nextWord}");
                    lineWords.Add(nextWord);
                    wordsQueu.Dequeue();
                }
                else
                {
                    string newLine = string.Join(" ", lineWords);
                    finalParagraph.Append(newLine);
                    finalParagraph.Append('\n');
                    lineWords.Clear();
                    lineSize = 0;

                }
                nextWord = wordsQueu.Peek();
            }

            /*
            do
            {
               // string nextWord = wordsQueu.Peek();
                lineSize = lineSize + nextWord.Length + 1;
                if (lineSize <= len )
                {
                    Console.WriteLine($"We are processing {nextWord}");
                    lineWords.Add(nextWord);
                    wordsQueu.Dequeue();
                }
                else
                {
                    string newLine = string.Join(" ", lineWords);
                    finalParagraph.Append(newLine);
                    finalParagraph.Append('\n');
                    lineWords.Clear();
                    lineSize = 0;

                }
                if (wordsQueu.Count() == 0)
                {
                    isFinished = true;
                }


            } while (!isFinished);
            */

            return finalParagraph.ToString();

        }
    }
}
