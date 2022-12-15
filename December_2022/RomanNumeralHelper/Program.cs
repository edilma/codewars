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
            Console.WriteLine(FromRoman("II"));


            Console.ReadLine();


        }
        //<convert2Roman>
        // This function transform a digit to roman numerals
        //it uses a function to give the values of roman
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
        //</convert2Roman>

        //<convert2Digit>
        //This function convert a digit number to roman numerals
        public static int FromRoman(string romanNumeral)
        {
            //<letters/Value>
            // Dictionay where I put the value of the roman letters
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
                //add the last number that it is not evaluated in the for loop
                sum = sum + myValues[romanNumeral[lengthRoman - 1]];
            }
            else
            {
                ///<less2letter>
                //Case when a roman number has 2 letters or less
                if (lengthRoman == 1)
                {
                    sum = myValues[romanNumeral[0]];
                }
                else
                {
                    // check the value of the 2 letters and decide what to do
                    // depending on their location
                    if ((lengthRoman == 2) & (isSmaller( romanNumeral[0], romanNumeral[1])))
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
        //<convert2Digit>



        //<compare-letters>
        // This function takes two letters and check their value in a dictionary
        // then compare the two values.  If the value is smaller returns true
        public static bool isSmaller(char a, char b)
        {
            Dictionary<char, int> myValues = new Dictionary<char, int>
            {
                {'I',1 } , {'V',5}, {'X',10}, { 'L',50}, {'C',100}, {'D',500}, {'M',1000}
            };
                        
            int valueA = myValues[a];
            int valueB = myValues[b];
          //Console.WriteLine($"En isSmaller el pimero es {myValues[a]} y el segundo es {myValues[b]} ");

            return valueA < valueB ? true : false;

        }
        //</compare-letters>

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


