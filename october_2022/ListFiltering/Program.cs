using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFiltering
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<object> test = new List<object>{ 1, 2, "a", "b", "aasf", "1", "123", 231 };
            //var result = GetIntegersFromList(test);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //

            //string str = "";
            //Console.WriteLine(IsIsogram(str));

            int a = 1;
            int b = 10;
            int c = 1;
            //int result = GetSum(a, b);
            //Console.WriteLine(result);

            int max = ExpressionsMatter(a, b, c);
            Console.WriteLine(max);


            Console.ReadLine();


        }
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            //var query = listOfItems.OfType<int>();
          return listOfItems.OfType<int>();


        }
        public static bool IsIsogram(string str)
        {

            var distinct = str.ToUpper().Distinct().Count();
            if (distinct!=str.Length)
            {
                return false;
            }
            return true;

            // Shorter code is:
            // return str.ToUpper().Distinct().Count() == str.Length;

        }
        public static  int GetSum(int a, int b)
        {
            int sum = 0;
            int j ;
            if (a<=b)
            {
                j = a;
            }
            else
            {
                j = b;
                b = a;
            }
            for (int i = j; i < b+1; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
        public static int ExpressionsMatter(int a, int b, int c)
        {
            int firsPar = (a + b) * c;
            int SecPar = a + (b * c);
            int ThirPar = (a * b) + c;
            int FourPar = a * b * c;
            int fifthPar = a * (b + c);
            int sixPar = a + b + c;

            int[] results = { firsPar, SecPar, ThirPar, FourPar, fifthPar, sixPar };
            return results.Max();



        }




    }
}
