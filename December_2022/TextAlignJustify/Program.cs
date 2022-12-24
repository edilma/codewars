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
            List<string> wordsLine = (paragraph.Split().ToList());
            int letters = wordsLine.Select(x => x.Length).Sum();
            string testDistri = Justify(paragraph, 12);
            Console.WriteLine(testDistri);
            Console.ReadLine();
        }
        public static string Justify(string str, int len)
        {
            // create an array of words
            List<string> words = str.Split(' ').ToList();
            // create the string to generate
            StringBuilder justPara = new StringBuilder();
          
            
            bool isFinish = false;

            while (!isFinish)
            {
                if (words.Count() <= 1)
                {
                    justPara.Append(words[0]);
                    isFinish = true;
                }
                else
                {
                    int inicio = 0;
                    List<string> wordsinLine = new List<string>();
                    int lines = 0;
                    while (inicio< words.Count - 1)
                    {
                        
                        if (lines <= 1)
                        {
                            wordsinLine.Add(words[inicio]);
                            inicio++;
                        }
                        else
                        {
                            string newRenglon = DistributeSpaces(wordsinLine, len);
                            justPara.Append(newRenglon);
                            justPara.Append('\n');
                            wordsinLine.Clear();
                            inicio++;
                        }
                        lines = MinNumberLines(wordsinLine, len);

                    };

                }
                
            }
            return justPara.ToString();






        }
        // this function distribute the spaces in lines that are not last one
        // the words need to be equal or less than needed to fill the line 
        // working 
        public static string DistributeSpaces(List<string>wordsLine, int len)
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
                int i= 0;
                do
                {
                    wordsLine[i] = wordsLine + "-";
                    spacesLeft--;
                } while (spacesLeft>0);
                return String.Join(" ", wordsLine);
            
            }

            
        }
        public static int MinNumberLines(List<string> words, int len)
        {
            // totalLetters is how many letters in totals 
            int totalLetters = words.Select(x => x.Length).Sum();

            // numberOfWords is how many words
            int numberOfWords = words.Count;
            // minimum number of spaces needed.  Last word doesn't need
            int minNumberSpaces = numberOfWords - 1;

            int minNumberofLines = (totalLetters + minNumberSpaces) / len;

            return minNumberofLines;
        }


    }
}
