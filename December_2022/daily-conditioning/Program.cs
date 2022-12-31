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
            //int answer = GetSum(-1, 2);
            //double time = 11.8;
            int seconds = 0;
            Console.WriteLine(GetReadableTime(seconds));

            //Console.WriteLine(Litres(time));
           
            Console.ReadLine();
        }
        public static string GetReadableTime(int seconds)
        {
            int hours = seconds / 3600;
            int mins = (seconds - hours * 3600) / 60;
            int secs = seconds - hours*3600- mins * 60;
            
          
            return ($"{hours:00}:{mins:00}:{secs:00}");


        }
        public static int Litres(double time)
        {
            int litters = (int)Math.Floor(time * 0.5);
            //The fun begins here.
            return litters;
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
