using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_validation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ojo este item no funciona
            //string test = "12.34.56 .1";

            string test = "abc.def.ghi.jkl";
            Console.WriteLine(IsValidIp(test));
            

            Console.ReadLine();

        }

        public static bool IsValidIp(string ipAddres)
        {
            bool answer = false;
            string[] numbers = ipAddres.Split('.');

            if (numbers.Length!=4)
            {
                return false;
            }
            else
            {
                foreach (string num in numbers)
                {
                    answer = is_number_valid(num);
                    if (!answer)
                    {
                        return false;
                    }
                    
                }
                return answer;
            }
            
        }
        public static bool is_number_valid(string str)
        {
            if (str.Length>3)
            {
                return false;
            }
            if (str.StartsWith("0")&& str.Length>1)
            {
                return false;
            }
            foreach (char item in str)
            {
                if (!Char.IsDigit(item))
                {
                    return false;
                }
            }
           

           int number;
           bool isNumber = Int32.TryParse(str, out number);
            if (isNumber is false)
            {
                return false;
            }
            else
            {
                if (number<0 || number>255)
                {
                    return false;
                }
                return true;
            }

          
        }

    }
}
