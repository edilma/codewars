using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbersToreversedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            long number= 0;
            long[] result = Digitize(number);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


        }
        public static long[] Digitize(long n)
        {
            bool falta = true;
            List<long> result = new List<long>();
            if (n == 0)
            {
                result.Add(0);
                return result.ToArray();
            }
            else {
                if (n >= 1)
                {
                    long next = n % 10;
                    result.Add(next);
                    n = n / 10;
                }
            };





            
            else { 
                while (falta)
                {
                    if (n%10>=1)
                    {
                        long next = n % 10;
                        result.Add(next);
                        n = n/10;
                    }
                    else
                    {
                        falta = false;
                    }
               
                }
            }
            return result.ToArray();
        }
    }
}
