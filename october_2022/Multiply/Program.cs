using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = 6;

            //Console.WriteLine( CustomMath.multiply(a, b));

            //List<Object> newList = new List<object> { "hello", 1, 8, "my house", 9, true, 8 };
            // IEnumerable<int> result = ListFilterer.GetIntegersFromList(newList);
            //foreach (var  item in newList)
            //{
            //    Console.WriteLine(item.GetType().ToString());
            //}
            //foreach (int item in result)
            //{
            //    Console.WriteLine(item);
            //}

            int[] anArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
           
           Console.WriteLine(CreatePhoneNumber(anArray));
            //Console.WriteLine(phoneNumber);


            Console.ReadLine();
        }

        public static string CreatePhoneNumber(int[] numbers)
        {
            //My solution 

            return  $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";


            //return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");



        }



    }
    public class CustomMath
    {
            public static int multiply(int a, int b)
    {
        return a* b;
    }

    }
    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
           return listOfItems.OfType<int>();

            

            // My solution
            //int a = 5;
            //List<int> newList = new List<int>();
            
            //foreach (var item in listOfItems)
            //{
            //    if (item.GetType() == a.GetType())
            //    {
            //        newList.Add((int)item);
            //    }
                
            //}
            //return newList;
            
        }
    }
}
