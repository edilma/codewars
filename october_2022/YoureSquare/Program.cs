using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoureSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 282172; has to be true
            int b = 186986;
            //186986 has to be false
            Console.WriteLine(IsSquare(b));
            Console.ReadLine();
        }
        
        public static bool IsSquare(int n)
        {
            double rootN = Math.Sqrt(n);
            int number;
            bool isInteger = Int32.TryParse(rootN.ToString(), out number);
            
                return rootN * rootN == n ? true : false;
                       
           
            
        }
    }
}
