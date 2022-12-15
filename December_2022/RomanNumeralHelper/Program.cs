using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
           // Console.WriteLine(ToRoman(n));
            //Console.WriteLine(900 % 1000);
            //Console.WriteLine(TheLetter(956));
            Console.WriteLine(FromRoman("IV"));


            Console.ReadLine();


        }

        public static string ToRoman(int n)
        {
            string roman = "";

            do
            {
                roman = roman + TheLetter2(n).Item1;
                n = n - TheLetter2(n).Item2;

            } while (n != 0);
            return roman;
        }



        public static int FromRoman(string romanNumeral)
        {
            //<letters/Value>
            Dictionary<char, int> myValues = new Dictionary<char, int>
            {
                {'I',1 } , {'V',5}, {'X',10}, { 'L',50}, {'C',100}, {'D',500}, {'M',1000}
            };
            //</letters/Value>

            int sum = 0;
            int lengthRoman = romanNumeral.Length;
  

            if (lengthRoman >= 3)
            {
                for (int i = 1; i <= lengthRoman-1; i++)
                {
                    int current = myValues[romanNumeral[i-1]];
                    int after = myValues[romanNumeral[i ]];
                    sum = (current < after ? sum - current : sum + current);

                }
                sum = sum + myValues[romanNumeral[lengthRoman - 1]];
            }
            else
            {
                ///<less2letter>
                //When a roman number has 2 letters or less
                if (lengthRoman == 1)
                {
                    sum = myValues[romanNumeral[0]];
                }
                else
                {
                    if ((lengthRoman == 2) & (isBigger( romanNumeral[0], romanNumeral[1])))
                    {
                        sum = myValues[romanNumeral[1]] - myValues[romanNumeral[0]];
                    }
                    else
                    {
                        sum = myValues[romanNumeral[1]] + myValues[romanNumeral[0]];
                    };

                }
                /// < /less2letter >
                /// 
            }


            return sum;
        }

        public static bool isBigger(char a, char b)
        {
            Dictionary<char, int> myValues = new Dictionary<char, int>
            {
                {'I',1 } , {'V',5}, {'X',10}, { 'L',50}, {'C',100}, {'D',500}, {'M',1000}
            };
                        
            int valueA = myValues[a];
            int valueB = myValues[b];
          //  Console.WriteLine($"En isBigger el pimero es {myValues[a]} y el segundo es {myValues[b]} ");

            return valueB < valueA ? true : false;

        }

        public static string TheLetter(int n)
        {
            
            if (n > 999)
            {
                return "M";
            }
            if (n > 899)
            {
                return "CM";
            }
            if (n > 499)
            {
                return "D";

            }
            if (n > 399)
            {
                return "CD";
            }
            if (n > 99)
            {
                return "C";
            }
            if (n > 89)
            {
                return "XC";
            }
            if (n > 49)
            {
                return "L";
            }
            if (n > 39)
            {
                return "XL";
            }
            if (n > 9)
            {
                return "X";
            }
            if (n > 8)
            {
                return "IX";
            }
            if (n > 5)
            {
                return "V";
            }
            if (n > 3)
            {
                return "IV";
            }
            else
            {
                return "I";
            }
         
        }
        public static (string,int) TheLetter2(int n)
        {

            if (n > 999)
            {
                return ("M",1000);
            }
            if (n > 899)
            {
                return ("CM",900);
            }
            if (n > 499)
            {
                return ("D",500);

            }
            if (n > 399)
            {
                return ("CD",400);
            }
            if (n > 99)
            {
                return ("C",100);
            }
            if (n > 89)
            {
                return ("XC",90);
            }
            if (n > 49)
            {
                return ("L",50);
            }
            if (n > 39)
            {
                return ("XL",40);
            }
            if (n > 9)
            {
                return ("X",10);
            }
            if (n > 8)
            {
                return ("IX",9);
            }
            if (n > 4)
            {
                return ("V",5);
            }
            if (n > 3)
            {
                return ("IV",4);
            }
            else
            {
                return ("I",1);
            }

        }
    }
}


