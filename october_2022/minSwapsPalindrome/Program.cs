using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minSwapsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "aabcb";
            int result = SwapsToPalindrom(word);

            Console.WriteLine(result);
            Console.ReadLine();

        }
        //Given a string S, the task is to find out the minimum
        //no of adjacent swaps required to make string s palindrome.
        //If it is not possible, then return -1.
        public static int SwapsToPalindrom( string str)
        {
            bool IsPossible = IsPossiblePalindrome(str);
            int count = 0;
            if (IsPossible)
            {
                for (int i = 0; i < str.Length/2; i++)
                {
                    if (str[i] != str[str.Length - 1]-i)
                    {
                        count++;
                    }
                }
                return count;
            }
            else
            {
                return -1;
            }
        }





        // check if it can be a palindrome ( even number, even distinc. 
        //Odd number is total/2 plus one
        public static bool IsPossiblePalindrome (string str)
        {
           
            int countLetters = str.Length;
            // convert the str to an IEnumerable 
            char[] theletters = str.ToCharArray();

            char[] distincletters = theletters.Distinct().ToArray();
            // check cuantas unique letters there are
            int countUniqueLetters = distincletters.Count();
            int isEven = countLetters % 2;
            
            if (isEven % countUniqueLetters != 0)
            {
                //is palindrome and check the movements
                return true;
            }
            else
            {
                return false;
            }
            if (isEven !=0 && countLetters % countUniqueLetters != 1)
            {
                return false;
            }
            else
            {
                return true;
            }



        }

    }
}
