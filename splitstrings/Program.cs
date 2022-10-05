using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace splitstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string testEven = "abcdefg";
            //string testOdd = "abcdefg";
            string[] resultEven = Solution(testEven);
            // string[] resultOdd = Solution(testOdd);

            foreach (var item in resultEven)
            {
                Console.WriteLine(item);
            }
            //for (int i = 0; i < testEven.Length; i++)
            //{
            //    Console.WriteLine("This is the result odd {0}", resultOdd[i]);
            //}
            Console.ReadLine();
            
        }
        public static string[] Solution(string str)
        {
            int lenghtStr = str.Length;
            if (lenghtStr%2 ==0)
            {
                return StringEven(str);
            }
            else
            {
                string newString = str+ "_";
                return StringEven(newString);
            }


        }

        public static string[] StringEven(string str)
        {
            char[] arrayChars = str.ToCharArray();
            List<string> resultList = new List<string>();
            for (int i = 0; i < str.Length-1; i+=2)
            {
                string coupleChar = new string(arrayChars, i, 2);
                resultList.Add(coupleChar);
            }
            return resultList.ToArray();
        }

    }
}
