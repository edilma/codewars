﻿using System;
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
            int[] test3 = { 1, 2, 1 };
            int[] test4 = { 2, 1, 3, 1, 2, 2, 2, 2 };
            Dictionary<string, List<int>> result = GetPeaks(test4);

            //Console.WriteLine(test2[0]);

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
           // List<int> ogArray = new List<int>(arr);
            Dictionary<string, List<int>> solution = new Dictionary<string, List<int>>();
            List<int> peaks = new List<int>();
            List<int> posPeaks = new List<int>();
           

            for (int i = 1; i < arr.Length-1; i++)
            {
                int currentPeak;
                int currentPos=-1 ;

                if (arr[i-1]<arr[i])
                {
                    currentPeak = arr[i];
                    currentPos = i;
                }




                if ((arr[i + 1] < arr[i]) &(currentPos == -1))
                    {
                        currentPeak = arr[i];
                        currentPos = i;
                        peaks.Add(currentPeak);
                        posPeaks.Add(currentPos);
                    }
                    

               


            }
            solution.Add("pos:", posPeaks);
            solution.Add("peaks:", peaks);

            return solution;

            


        }
        


            public static Dictionary<string, List<int>> GetPeaks2(int[] arr)
        {
            List<int> ogArray = new List<int>(arr);
            Dictionary<string, List<int>> solution = new Dictionary<string, List<int>>();
            List<int> peaks = new List<int>();
            List<int> posInt = new List<int>();


            if (ogArray.Count<=2)
            {
                solution.Add("pos:", posInt);
                solution.Add("peaks:", peaks);
                return solution;
            }
            else 
            {
                int current = 1;
                int before = 0;
                int after = 2;
                for (int i = current; i < ogArray.Count - 1; i++)
                {
                    
                    if (isPeak(ogArray[current], ogArray[before], ogArray[after]))
                    {
                        posInt.Add(current);
                        peaks.Add(ogArray[current]);
                        before = current+1;
                        current +=2;
                        
                    }
                    else
                    {
                        if (ogArray[current] == ogArray[after])
                        {
                            after = current+1;
                        }
                    }

                }

                solution.Add("pos:", posInt);
                solution.Add("peaks:", peaks);

                return solution;
            }


            
        }

        public static bool isPeak(int current, int before, int after)
        {

           return  (current > before && current > after)? true : false;
            
        }
    }
}
