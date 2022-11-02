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
            long number= 56000;
            long[] result = Digitize(number);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


        }
        public static long[] Digitize(long n)
        {
            
            List<long> result = new List<long>();
            if (n == 0)
            {
                result.Add(0);
                return result.ToArray();
            }
            else 
            {
                while (n>=1)
                {
                    result.Add(n % 10);
                    n = n / 10;

                }
                return result.ToArray();
            };
          
        }
            
        }
    }

