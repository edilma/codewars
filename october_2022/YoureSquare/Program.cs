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
            //int n = 282172; has to be false
            int b = 63001;
            //186986 has to be false
            Console.WriteLine(IsSquare(b));
            Console.WriteLine(Math.Sqrt(b));
            
            Console.ReadLine();

        }
        //find the perfect quare of a number 
        public static bool IsSquare(int n)
        {
            int[] noEndSq = { 2, 3, 7, 8 };
            int[] squares = { 0,4,9 };
            int lastDigit = n % 10;
            //numbers smaller than 10 that are square
            if (squares.Contains(n))
            {
                return true;
            }
            else
            {
                if (noEndSq.Contains(lastDigit))
                {
                    return false;
                }
                else
                {                  
                    int poss1 = 1;
                    int poss2 = 9;

                    for (int i = poss1; i < n / 2; i=i+10)
                    {
                        if (i * i == n)
                        {
                            return true;
                        }
                        else
                        {
                            if (i * i > n)
                            {
                                i = n + 1;
                            }
                        }

                    }
                    for (int i = poss2; i < n / 2; i = i + 10)
                    {
                        if (i * i == n)
                        {
                            return true;
                        }
                        else
                        {
                            if (i * i > n)
                            {
                                i = n + 1;
                            }
                        }

                    }

                    return false;

                }
            }
            //numbers bigger than 10 that are square
           
            
            //double rootN = Math.Sqrt(n);
            //int number;
            //bool isInteger = Int32.TryParse(rootN.ToString(), out number);
            
            //    return rootN * rootN == n ? true : false;
                       
           
            
        }

    }
}
