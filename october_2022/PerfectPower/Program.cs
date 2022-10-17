using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectPower
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 500;
            //double root = Math.Pow(4, 2);
            //Console.WriteLine(root);

          Console.WriteLine(IsPerfectPower3(num));
            Console.ReadLine();

        }

        public static (int, int)? IsPerfectPower3(int n)
        {
            int a = 2;
            int factor = 1;
            if (n%10==0)
            {
                a = 5;
                factor = 5;

            }
            else
            {
                if (n%3==0)
                {
                    a = 3;
                    factor = 3;
                }
            }

                        
            while (a < n)
            {
                if (n % a == 0)
                {
                    int b = 2;
                    do
                    {
                        if (Math.Pow(a, b) == n)
                        {
                            return (a, b);
                        }
                        else {b++; }
                       

                    } while (Math.Pow(a, b) <= n);
                    

                }
                a=a + factor;

            }
            return null;
        }






        }
}
