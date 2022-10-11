using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop_gninnips_My_sdroW
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Just gniddik ereht is llits one more";
            string test2 = "this";
            Console.WriteLine(SpinWordsBest(test));




            Console.WriteLine(SpinWords(test));
            Console.ReadLine();

        }
        // Function that returns all 5 o more letters word  reversed
        // use a helpers function to reverse the words
        public static string SpinWords(string sentence)
        {
            List<string> wordsSentence = sentence.Split().ToList();
            List<string> result = new List<string>();

            for (int i = 0; i < wordsSentence.Count; i++)
            {
                string turn = wordsSentence[i];
                if (turn.Length >= 5)
                {
                    string changed = ReverseString(wordsSentence[i]);
                    result.Add(changed);
                }
                else
                {
                    result.Add(turn);
                }


            }
            string final = String.Join(" ", result);
            return final;
        }
        // function that reverse the words
        public static string ReverseString(string word)
        {
            char[] newWord = word.ToArray();
            Array.Reverse(newWord);
            string result = new string(newWord);
            return result;

        }

        public static string SpinWordsBest(string sentence)
        {

            return String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
        }

    }
}