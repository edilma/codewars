using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daily_conditioning
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string word = "abcdef";
            string[] result = Solution(word);
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
            */
            int answer = GetSum(-1, 2);
            Console.WriteLine(answer);
           
            Console.ReadLine();
        }
        public static  int GetSum(int a, int b)
        {
            int first;
            int last;
            int sum = 0;
            if (a<b)
            {
                first = a;
                last = b;
            }
            else
            {
                first =  b;
                last = a;
            }
            for (int i = first; i < last+1; i++)
            {
                sum = sum + i;
            }

            return sum;
        }


        public static string[] Solution(string str)
        {
            List<string> strPairs = new List<string>();
            string newString = (str.Length % 2 != 0) ? (str + "_") : str;
            
            for (int i = 0; i < newString.Length; i=i+2)
            {
                strPairs.Add(newString.Substring(i,2));
            }

            string[] result = strPairs.ToArray();
            return result;




        }

    }
}
