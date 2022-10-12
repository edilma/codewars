using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add("123456789", "987654322"));

            Console.ReadLine();

        }
        
         public static string Add(string a, string b)
        {
            // The biggest number will be a long int.  
            // sum the digits of the digits of the string
            long numa;
            long numb;
            Int64.TryParse(a, out numa);
            Int64.TryParse(b, out numb);

            long total = numa + numb;

            // convert the numbers to string and return it
            string result = total.ToString();

            return result;
 
        }

    }
}
