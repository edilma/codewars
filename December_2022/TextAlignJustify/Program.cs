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
            string paragraph = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor mauris, at elementum ligula tempor eget. In quis rhoncus nunc, at aliquet orci. Fusce at dolor sit amet felis suscipit tristique. Nam a imperdiet tellus. Nulla eu vestibulum urna. Vivamus tincidunt suscipit enim, nec ultrices nisi volutpat ac. Maecenas sit amet lacinia arcu, non dictum justo. Donec sed quam vel risus faucibus euismod. Suspendisse rhoncus rhoncus felis at fermentum. Donec lorem magna, ultricies a nunc sit amet, blandit fringilla nunc. In vestibulum velit ac felis rhoncus pellentesque. Mauris at tellus enim. Aliquam eleifend tempus dapibus. Pellentesque commodo, nisi sit amet hendrerit fringilla, ante odio porta lacus, ut elementum justo nulla et dolor.";
            string paragraph2 = "123 45 6";
            List<string> wordsLine = (paragraph2.Split().ToList());
            //int letters = wordsLine.Select(x => x.Length).Sum();
            string testDistri = Justify2(paragraph2, 7);
            //string testDistri = DistributeSpaces(wordsLine, 29);
            Console.WriteLine(testDistri);
            // Console.WriteLine(MinNumberLines(wordsLine, 10));
            Console.ReadLine();




        }
        public static string Justify(string str, int len)
        {
            List<string> words = str.Split(' ').ToList();
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
                    int currentWord = 0;
                    List<string> wordsinLine = new List<string>();
                    int newlineLenght = 0;
                    string newRenglon="";
                    while (currentWord < words.Count - 1)
                    {

                        if (newlineLenght <= len)
                        {
                            wordsinLine.Add(words[currentWord]);
                            words.RemoveAt(0);
                            currentWord++;
                        }
                        else
                        {
                             newRenglon = String.Join(" ", wordsinLine);
                            justPara.Append(newRenglon);
                            justPara.Append('\n');
                            wordsinLine.Clear();
                        }
                        newlineLenght += words[currentWord].Length + 1;
                    };
                    justPara.Append(newRenglon); 

                }

            }
            return justPara.ToString();
        }
        // this function distribute the spaces in lines that are not last one
        // the words need to be equal or less than needed to fill the line 
        // working 
        public static string DistributeSpaces(List<string> wordsLine, int len)
        {
            int totalLetters = wordsLine.Select(x => x.Length).Sum();
            int numberOfWords = wordsLine.Count;
            // spacesLeft are the extra spaces to distribute
            int spacesLeft = len - totalLetters; 
          
            bool doContinue = true;
            while (doContinue)
            {
                for (int i = 0; i < wordsLine.Count - 2; i++)
                {
                    wordsLine[i] = wordsLine[i] + " "; 
                    if (spacesLeft == 0)
                    {
                        break;
                    }
                }
                spacesLeft--;
                doContinue = false;
            }
            string answer = string.Join(" ", wordsLine);

            return answer;
          



        }
             
        public static string Justify2(string str, int len)
        {
            StringBuilder finalParagraph = new StringBuilder();
            List<string> words = str.Split(' ').ToList();
            Queue<string> wordsQueu = new Queue<string>();
            foreach (string word in words)
            {
                wordsQueu.Enqueue(word);
            }
            List<string> lineWords = new List<string>();
            int lineSize = 0;
            string nextWord = "";
            string newLine = "";
            // process the words leaving the last line withou process 
            while (wordsQueu.Count>1)
            {
                nextWord = wordsQueu.Peek();
                if (lineSize <len)
                {
                    //Console.WriteLine($"We are processing {nextWord}");
                    lineWords.Add(nextWord);
                    wordsQueu.Dequeue();
                    nextWord = wordsQueu.Peek();
                }
                else
                {
                    newLine = DistributeSpaces(lineWords, len);
                    finalParagraph.Append(newLine);
                    finalParagraph.Append('\n');
                    lineWords.Clear();
                    lineSize = 0;

                }
                lineSize = lineSize + nextWord.Length + 1;

            }
            // process the last line.
            lineWords.Add(nextWord);
            newLine = string.Join(" ", lineWords);
            finalParagraph.Append(newLine);
            return finalParagraph.ToString();

        }


    }
}
