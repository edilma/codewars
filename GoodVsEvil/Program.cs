using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodVsEvil
{
    class Program
    {
        static void Main(string[] args)
        {
            string good = "0 0 0 0 0 10";
            string evil = "0 1 1 1 1 0 0";

            Solution(good, evil);


            Console.ReadLine();
        }

        static void Solution(string good, string evil)
        {

            int goody = GoodResult(good);
            int bady = EvilResult(evil);

            if (goody == bady)
            {
                Console.WriteLine("Battle Result: No victor on this battle field");
            }
            else
            {
                if (goody > bady)
                {
                    Console.WriteLine("Battle Result: Good triumphs over Evil");
                }
                else
                {
                    Console.WriteLine("Battle Result: Evil eradicates all trace of Good");
                }
            }
        }
        static int GoodResult (string str)
        {
            string[] myScores = str.Split(' ');
            int total = 0;
            List<int> pointsGood = new List<int> { 1, 2, 3, 3, 4, 10 };

                for (int i = 0; i < myScores.Length; i++)
                {
                    int scoreItem;
                    Int32.TryParse(myScores[i], out scoreItem);
                    total += scoreItem * pointsGood[i];
                }
                return total;

           

           
        }
        static int EvilResult(string str)
        {
            string[] myScores = str.Split(' ');
            int total = 0;
            List<int> pointsEvil = new List<int> { 1, 2, 2, 2, 3, 5, 10 };

            for (int i = 0; i < myScores.Length; i++)
            {
                int scoreItem;
                Int32.TryParse(myScores[i], out scoreItem);
                total += scoreItem * pointsEvil[i];
            }
            return total;
        }
    }
}
