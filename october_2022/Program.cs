using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace october_2022
{
    class Program
    {
        static void Main(string[] args)
        {


            // Reverse a string//
           //string reverseString = "world";
           //Console.WriteLine(Solution(reverseString));
           // Console.WriteLine ("// ----- //");
           // Console.WriteLine(SolutionOptimize(reverseString));

            string sentence = "This is an example";
            //string[] newArray = sentence.Split(' ');
            //string otro="";
            //Array.Reverse(newArray);
            //for (int i = 0; i < newArray.Length; i++)
            //{
            //    otro = newArray[i]+ " " + otro;
               
            //}


            //Console.WriteLine("{0}", otro);

            Console.WriteLine(ReverseWords(sentence));




            Console.ReadLine();
        }





        // Function to reverse a string ( my take)
        public static string Solution(string str)
        {
            char[] newArray = str.ToArray();
            Array.Reverse(newArray);
            string result = new string(newArray);
            return result;
        }
        // Function to reverse a string ( optimize)
        public static string SolutionOptimize(string str)
        {
            return new string(str.ToArray().Reverse().ToArray());

        }
        public static string ReverseWords(string str)
        {

            //string[] newArray = str.Split(' ');
            //Array.Reverse(newArray);
            //string result = "";
            //for (int i = 0; i <= newArray.Length-1; i++)
            //{

            //    string reverseWord = (SolutionOptimize(newArray[i]));
            //    //Console.WriteLine(reverseWord);
            //    result += reverseWord + " ";
            //}

            //return result;

            string reverseString = String.Empty;

            string[] sentrev = new string []{ };
            string supernew = "";

            string[] newArray = str.Split(' ');
            foreach (string word  in newArray)
            {
                string flipped = SolutionOptimize(word);
                supernew += flipped + " ";
                Console.WriteLine($"{supernew} is {supernew.Count()} and original is {str.Count()}");
                
            }

            foreach (var item in sentrev)
            {
                Console.WriteLine(item);
            }
            return "hola";


 
        }




    }
}
