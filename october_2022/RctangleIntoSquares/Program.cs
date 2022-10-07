using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RctangleIntoSquares
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<int> answer = new List<int>();
            answer = sqInRect(20, 14);

       
            foreach (int item in answer)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();


        }
        public static List<int> sqInRect(int lng, int wdth)
        {
            List<int> smallSquares = new List<int>();
            int temporalSmall = 0;

            if (lng == wdth)
            {

                return null;
            }
            else
            { 

            while (wdth > 0)
            {

               
                if (lng >= wdth)
                {
                    smallSquares.Add(wdth);
                    temporalSmall = lng - wdth;
                    lng = wdth;
                    wdth = temporalSmall;

                }
                else
                {
                    smallSquares.Add(lng);
                    temporalSmall = lng;
                    lng = wdth - lng;
                    wdth = temporalSmall;

                }

            }
            return smallSquares;
            }
        }







            //do
            //    {
            //        totalArea = lng * wdth;
            //        if (lng>wdth)
            //    {
            //       biggerSide = lng;
            //       smallerSide = wdth;
            //    }
            //    else
            //    {
            //        biggerSide = wdth;
            //        smallerSide = lng;
            //    }
            //    int sq = (int)Math.Floor(Math.Sqrt(totalArea));
            //    Console.WriteLine($"Bigger side is {biggerSide}, small is {smallerSide}");
            //    Console.WriteLine("Total Area is {0} and sqare root is {1}", totalArea, sq);
            //    int smallsideToSquare = smallerSide * smallerSide;


            //    if (smallsideToSquare <= sq)
            //    {
            //        smallSquares.Add(smallerSide);
            //        biggerSide = biggerSide - smallerSide;
            //    }
            //    else
            //    {
            //        return smallSquares;
            //    }
            //    Console.WriteLine($"new long is {lng}, new width is {wdth}");

            //} while (lng >= 0);

            //foreach (int item in smallSquares)
            //{
            //    Console.WriteLine(item);
            //}




        }

       


        
    }

