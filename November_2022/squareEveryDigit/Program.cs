using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareEveryDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 91188;
            //Console.WriteLine(num * num);
            Console.WriteLine(SquareDigits(num));
            Console.ReadLine();

        }

        public static int SquareDigits(int num)
        {
            //string digs = num.ToString();
            //char[] arr = digs.ToArray();
            bool isFinish = false;
            List<int> digits = new List<int>();
            string ans="";

            while (num%10>=1)
            {
                int sq = (num % 10) ;
                digits.Add(sq *sq);
                num = num / 10;

            }
            for (int i = digits.Count-1; i >=0; i--)
            {
                ans = ans + digits[i].ToString();
               
            }
            //  Console.WriteLine(ans);
            int answer; 
            int.TryParse(ans, out answer);
            return answer;

            //foreach (int item in digits)
            //{
            //    Console.WriteLine("the item is {0}", item);
            //}


            return -1;
        }
    }
}
