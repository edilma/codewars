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
            int num = 8;
            Console.WriteLine(IsPerfectPower(num));
            Console.ReadLine();

        }
        public static (int, int)? IsPerfectPower(int n)
        {
            // math.power(base, power)
            int kPower=2;
            int mBase=2;
            while (mBase<n)
            {
                do
                {
                    if (Math.Pow(mBase, kPower) == n)
                    {
                        return (mBase, kPower);
                    }
                   mBase++;
                } while (kPower<n);


                kPower++;

            }
           
            return null;
        }

        
        
    }
}
