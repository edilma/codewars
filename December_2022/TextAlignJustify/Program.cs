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
            string testDistri = DistributeSpaces(wordsLine, 42);
            Console.WriteLine(testDistri);
            Console.ReadLine();
        }
        public static string Justify(string str, int len)
        {
            // create an array of words
            List<string> words = str.Split(' ').ToList();
            StringBuilder justPara = new StringBuilder();

            if (words.Count()<=1)
            {
                justPara.Append(words[0]);
                justPara.Append('\n');
            }
            
            int countWord = 0;
            int totalWords = words.Count();
            int i = 0;

            while (totalWords!= countWord)
            {
                List<string> wordsToUse = new List<string>();
                int numLetters = 0;
                int wordsLine = 0;
                
                do
                {
                    numLetters = words[i].Length;
                    if (numLetters <=len)
                    {
                        numLetters = numLetters + 1;
                        i++;
                        wordsToUse.Add(words[i]);

                    }
                    else
                    {
                       string newRenglon =  DistributeSpaces(wordsToUse, len);
                        justPara.Append(newRenglon);
                        justPara.Append('\n');
                    }
                    

                } while (numLetters<len);
               


                /*

                if (numLetters < len)
                {
                    letters = letters + 1;
                    wordsLine++;
                    i++;
                    // distribute the spaces
                    string line = 
                    justPara.Append(line);
                }
                */

            }

            // calculate how many words fit in a line
            //check if it is a last line or only a word
            // calculate how many words in the line
             
            //repeat

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
    }
}
