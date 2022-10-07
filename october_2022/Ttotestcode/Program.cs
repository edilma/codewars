using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ttotestcode
{
    class Program
    {
        static void Main(string[] args)
        {

            int biggerSide = 20; 
            int smallerSide =  14;
            int newSmall = 0;
            int area = biggerSide * smallerSide;

            List<int> smallSquares = new List<int>();

            
                
                if (biggerSide >= smallerSide)
                {
                    smallSquares.Add(smallerSide);
                    newSmall = biggerSide - smallerSide;
                    biggerSide = smallerSide;
                    smallerSide = newSmall;
                }

               
                
                Console.WriteLine("The new smaller size is {0}", smallerSide);

                 
                
               
                
                
             
               



      

           
          



            foreach (int item in smallSquares)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


        }
    }
}
