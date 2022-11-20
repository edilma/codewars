using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareEveryDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 811181;
            //Console.WriteLine(num * num);
            //Console.WriteLine(SquareDigits(num));
            string word = "The sunset sets at twelve o' clock.";
            string word2 = "h";
            Console.WriteLine(AlphabetPosition(word));

            //int ind = word.IndexOf('s');
            //Console.WriteLine(ind);

            //string str = "GeeksForGeeks";
            
            //foreach (char item in str)
            //{
            //    int index1 = str.IndexOf(item);
            //    if (str.Contains(item))
            //    {
            //        Console.WriteLine("The Index Value of character 'k' is " + index1);
            //    }
            //}
            

            Console.ReadLine();

        }
        public static string AlphabetPosition(string text)
        {
            string letters = text.ToUpper();

            char[] alph = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        
            string ans=string.Empty;
            foreach (char letter in letters)
            {
               
                if (alph.Contains(letter))
                {
                    int index = Array.IndexOf(alph,letter)+1;
                    ans = ans+" " +  index.ToString();
                }

            }


            return ans;
        }

        public static int SquareDigits(int n)
        {

            List<int> digits = new List<int>();
            string ans="";

            while (n%10>=1)
            {
               int sq = (n % 10) ;
               digits.Add(sq *sq);
                n = n / 10;

            }
            for (int i = digits.Count-1; i >=0; i--)
            {
                ans = ans + digits[i].ToString();
               
            }
            
            int answer; 
            int.TryParse(ans, out answer);
            return answer;

           
        }

       
    }
}
