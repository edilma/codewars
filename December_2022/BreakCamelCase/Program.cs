using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string sample = "camelCasing";
            Console.WriteLine(BreakCamelCaseFactored(sample));
            Console.ReadLine();
        }

        public static string BreakCamelCaseFactored(string str)
        {

           return string.Concat(str.Select(x => Char.IsUpper(x)? " "+x : x.ToString()));
            
        }

        public static string BreakCamelCase(string str)
        {
            string newWord = "";
            foreach (char letter in str)
            {
                if (Char.IsUpper(letter))
                {
                    newWord = newWord + ' ' + letter;
                }
                else
                {
                    newWord = newWord + letter;
                }

            }
            return newWord;
        }


        public static string BreakCamelCaseUnderScore(string str)
        {
            string newWord = "";
            foreach (char letter in str)
            {
                if (letter == '_')
                {
                    newWord = newWord + ' ';
                }
                else
                {
                    newWord = newWord + letter;
                }

            }
            return newWord;
        }
    }
}
