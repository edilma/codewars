using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pickpeaks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 3, 2, 3, 6, 4, 1, 2, 3, 2, 1, 2, 3 };
            int[] test2 = { 1, 2, 2, 2, 1 };
            Dictionary<string, List<int>> result = GetPeaks(test2);



            foreach (var item in result)
            {
                Console.WriteLine(item.Key);
                foreach (var value in item.Value)
                {
                    Console.WriteLine(value);
                }
            }


            Console.ReadLine();

        }
        public static Dictionary<string, List<int>> GetPeaks(int[] arr)
        {
            List<int> ogArray = new List<int>(arr);
            Dictionary<string, List<int>> solution = new Dictionary<string, List<int>>();
            List<int> peaks = new List<int>();
            List<int> posInt = new List<int>();
     
            if (ogArray.Count==0)
            {
                solution.Add("pos:", posInt);
                solution.Add("peaks:", peaks);
                return solution;
            }
            else 
            {
                for (int i = 1; i < ogArray.Count - 2; i++)
                {
                    int aPeak = ogArray[0];
                 



                    if (ogArray[i] > ogArray[i - 1] && ogArray[i] > ogArray[i + 1])
                    {
                        posInt.Add(i);
                        peaks.Add(ogArray[i]);
                        aPeak = ogArray[i];

                    }
                }

                solution.Add("pos:", posInt);
                solution.Add("peaks:", peaks);

                return solution;
            }


            
        }
    }
}
