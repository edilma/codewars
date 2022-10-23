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
            int b = 10000;
            //186986 has to be false
            Console.WriteLine(IsSquare(b));
            Console.WriteLine(Math.Sqrt(b));
            
            Console.ReadLine();

        }
        //find the perfect quare of a number 
        public static bool IsSquare(int n)
        {
            int[] noEndSq = { 2, 3, 7, 8 };
            int[] squares = { 0,1,4,9 };
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
                    if (lastDigit ==1)
                    {
                        return IsSquareOfOne(n);
                    }
                    if (lastDigit == 4)
                    {
                        return IsSquareOfFour(n);
                    }
                    if (lastDigit==9)
                    {
                        return IsSquareOfNine(n);
                    }
                    if (lastDigit == 6)
                    {
                        return IsSquareOfSix(n);
                    }
                    if (lastDigit == 0)
                    {
                        return IsSquareOfZero(n);
                    }
                    if (lastDigit == 5)
                    {
                        return IsSquareOfFive(n);
                    }
                    return false;

                }
            }

            // other version usando square formula
            //return Math.Sqrt(n) % 1 == 0;
        }
        public static bool IsSquareOfOne (int n)
        {
            int poss1 = 1;
            int poss2 = 9;

            for (int i = poss1; i < n / 2; i = i + 10)
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
        public static bool IsSquareOfFour(int n)
        {
            int poss1 = 2;
            int poss2 = 8;

            for (int i = poss1; i < n / 2; i = i + 10)
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
        public static bool IsSquareOfNine(int n)
        {
            int poss1 = 3;
            int poss2 = 7;

            for (int i = poss1; i < n / 2; i = i + 10)
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
        public static bool IsSquareOfSix(int n)
        {
            int poss1 = 4;
            int poss2 = 6;

            for (int i = poss1; i < n / 2; i = i + 10)
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
        public static bool IsSquareOfZero(int n)
        {
            int poss1 = 10;
            int poss2 = 5;

            for (int i = poss1; i < n / 2; i = i + 10)
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
        public static bool IsSquareOfFive(int n)
        {
            int poss1 = 5;
           
            for (int i = poss1; i < n / 2; i = i + 10)
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
}
