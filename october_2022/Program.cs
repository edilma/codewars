using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace october_2022
{
    class Program
    {
        //interface IRandomizable
        //{
        //    double GetRandomNum(double upperBoundNumber);
        //}


        //public class RandomNumber: IRandomizable
        //{

        //    public RandomNumber() { }
            
                
        //    public double GetRandomNum( double upperBoundNumber)
        //    {
        //        Random rnd = new Random();
        //        double myrandom = rnd.NextDouble() * upperBoundNumber;
        //        return myrandom;
        //    }
        //}






        static void Main(string[] args)
        {



            // Exercise of 
            //bool sali = false;
            //RandomNumber number = new RandomNumber();
            //string str;
            //do
            //{
            //    Console.WriteLine("Enter a number for the upper bound");
            //    str = Console.ReadLine();
            //    try
            //    {
            //        double upperBound = Double.Parse(str);
            //        Console.WriteLine($"Random Number between 0 and {str} : {number.GetRandomNum(upperBound)}");
            //    }
            //    catch (Exception e) { };


            //} while (str!="exit");





            // RandomNumber number = new RandomNumber();
            //number.GetRandomNum(num);

            //Console.WriteLine(number.GetRandomNum(num));


            // Console.WriteLine((num));







            // Reverse a string//
            //string reverseString = "world";
            //Console.WriteLine(Solution(reverseString));
            // Console.WriteLine ("// ----- //");
            // Console.WriteLine(SolutionOptimize(reverseString));

            //string sentence = "This is an example";
            //string[] newArray = sentence.Split(' ');
            //string otro="";
            //Array.Reverse(newArray);
            //for (int i = 0; i < newArray.Length; i++)
            //{
            //    otro = newArray[i]+ " " + otro;

            //}


            //Console.WriteLine("{0}", otro);

            // Console.WriteLine(ReverseWords(sentence));

            string mysample = "abcdefg";
            string[] answer = Solution(mysample);

          /*
            string[] answer = Solution(mysample);
            char[] mywords = mysample.ToArray();

            int count = mywords.Length;
            string[] newArray = new string[(count / 2)];
            int helper = 0;


            for (int index = 0; index < mywords.Length - 1; index += 2)
            {
                string twochar = new string(mywords, index, 2);
                newArray[helper] = twochar;
                helper++;
                
                //Console.WriteLine(twochar);


            }
          */

            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }



            /*
                //Console.WriteLine(answer);
                foreach (var item in answer)
            {
                Console.WriteLine(item);
            }

            */

            Console.ReadLine();
        }


        public static string[] Solution(string str)
        {
            char[] mywords = str.ToArray();
            int count = str.Length;
            
            List<string> thewords = new List<string>();
                
            int helper = 0; 
            

            //check if the string has even number of characters
            if (count % 2 != 0)
            {
                int newLenght = (count / 2) + 1;
                int j = 0;
                
                for (int index = 0; index < mywords.Length - 1; index += 2)
                {
                    string twochar = new string(mywords, index, 2);
                    thewords[j] = twochar;
                    j++;
                }
                thewords[j+1] = mywords[count + 1] + "_";
                return thewords.ToArray();


            }
            string[] newArray = new string[(count / 2)];

            // if the numbers of characters is odd the last item ends with _
            for (int index = 0; index < mywords.Length - 1; index += 2)
            {
                string twochar = new string(mywords, index, 2);
                newArray[helper] = twochar;
                helper++;
            }
            return newArray;
        }

        public static string ReverseWords(string str)
        {
            string[] thewords = str.Split(' ');
            Array.Reverse(thewords);
            List<string> mywordsList = new List<string>(thewords);
            List<string> newSentence = new List<string>();

            for (int i = 0; i < mywordsList.Count;  i++)
            {
                newSentence.Add(SolutionOptimize(mywordsList[i]));
            }

            string result = String.Join(" ", newSentence);
            return result;

        }



        // Function to reverse a string ( my take)
        public static string Solutionxxx(string str)
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
        public static string ReverseWords2(string str)
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
        //Complete the solution so that it splits the string into pairs of two characters.
        //If the string contains an odd number of characters then it should replace the missing
        //second character of the final pair with an underscore ('_').
      




    }
}
