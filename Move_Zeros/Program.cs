using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_Zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myOriginal = { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };
            int[] result = new int[myOriginal.Length];
            result = MoveZeroes(myOriginal);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadLine();
        }
        public static int[] MoveZeroes(int[] arr)
        {
            List<int> myList = new List<int>();
                        
            Queue<int> mynumbers = new Queue<int>();
            int countOfZeros = 0;
            int arrayLenght = arr.Length;
            // Cree un queaeu with the non zero members
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]!=0)
                {
                    mynumbers.Enqueue(arr[i]);
                    
                }
                else
                {
                    countOfZeros += 1;
                }
            }
            //Add the nonZero quaue members to the list
            foreach (int item in mynumbers)
            {
                myList.Add(item);
            }
            //Complete the list with the zeros
            int countQueau = mynumbers.Count;
            for (int i = countQueau-1; i < arrayLenght-1; i++)
            {
                myList.Add(0);
            }
            
            return myList.ToArray();
        }
    }
}
