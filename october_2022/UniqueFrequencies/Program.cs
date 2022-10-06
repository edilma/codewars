using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueFrequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "aaabbbbbbbcccddddd";
            Dictionary<char, int> result = LettersinString(original);
            //foreach (KeyValuePair<char,int> item in result)
            //{
            //    Console.WriteLine($" {item.Key.ToString()}, has {item.Value}");

            //}
            int unique = UniqueFrequencies(result);

            Console.ReadLine();


        }

        // This dictionary has the letters as keys and the values as numbers of times they show up
        static Dictionary<char, int> LettersinString(string str)
        {
            char[] strArray = str.ToArray();
            Dictionary<char, int> strDicLetters = new Dictionary<char, int>();
            foreach (var letter in strArray)
            {
                if (!strDicLetters.ContainsKey(letter))
                {
                    strDicLetters.Add(letter, 1);
                }
                else
                {
                    strDicLetters[letter] += 1;
                }
            }
            return strDicLetters;

        }
        static  int UniqueFrequencies(Dictionary<char, int> lettersinWord)
        {
            //create a list of all the frequencies for the letters in the list of letters
            List<int> frequencies = new List<int>();
            foreach (KeyValuePair<char, int> item in lettersinWord)
            {
                frequencies.Add(item.Value);
            }

            // create a list of the unique frequencies
            List<int> uniqueFreq = frequencies.Distinct().ToList();

            // count how many elements in frequencies there are
            int elem = frequencies.Count();
            // count how many unique frequencies there are
            int diff = uniqueFreq.Count();
           
            // create a counter for the deletions needed to make the unique freq and freq the same
            int deletions = 0;
            // create a bool check for the do loop            
            bool needtoCheck = true;

            //create a dictionary with the list frequencies.  The key is the freq and value how many times they appear
            // they should appear only once. 
            Dictionary<char, int> repeatFreq = new Dictionary<char, int>();

            do
            {
                // if all the elements are unique return the deletions
                if (diff == elem)
                {
                    needtoCheck = false;
                    return deletions;
                }
                foreach (char freq in frequencies)
                {

                    if (!repeatFreq.ContainsKey(freq))
                    {
                        repeatFreq.Add(freq, 1);
                    }
                    else
                    {
                        repeatFreq[freq] += 1;
                    }
                }
                foreach (KeyValuePair<char, int> repfreq in repeatFreq)
                {
                    int times = repfreq.Value;
                    if (times != 1)
                    {
                        repeatFreq[repfreq.Key] = times - 1;
                        deletions += 1;
                    }


                }

                    //Populate the repeatFreq dictionary with the frequencies and how many times
                    //they appear.  All should be 1
                UniqueFrequencies(repeatFreq);




            } while (needtoCheck);


            return deletions;










            //frequencies.Sort();
            //uniqueFreq.Sort();
            //Console.WriteLine($"Before going in the for loop.  The frequency list has {frequencies.Count()}  items");
            //for (int i = 0; i < frequencies.Count; i++)
            //{
            //    int item = frequencies[i];
            //    int manyItem = frequencies.GroupBy(x => x == item).Count();
            //    if (manyItem !=1)
            //    {
            //        deletions +=1;
            //        frequencies.Remove(item);
            //    }
            //    Console.WriteLine($"Now the list frequency has {frequencies.Count()} items");
            //}






            //while (next)
            //{
            //    foreach (int freq in frequencies)
            //    {
            //        if (!uniqueFreq.Contains(freq))
            //        {
            //            if (!repeatFreq.ContainsKey(freq))
            //            {
            //                repeatFreq.Add(freq, 1);
            //            }
            //            else
            //            {
            //                repeatFreq[freq] += 1;
            //            }
            //        }



            //    }
            //}

            //else



            //Dictionary<int, int> repeatFreq = new Dictionary<int, int>();

            //foreach (KeyValuePair<int, int> item in repeatFreq)
            //{
            //    Console.WriteLine($"{item.Key} is in the list {item.Value}");
            //}








            /*
                        foreach (int item in frequencies)
                        {
                            Console.WriteLine(item);
                        }

                        //Console.WriteLine($"there are {diff} items in a list of {elem}");
                     */





        }



    }
    
}
