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

            List<Object> newList = new List<object> { "hello", 1, 8, "my house", 9, true, 8 };
            IEnumerable<int> result = ListFilterer.GetIntegersFromList(newList);
            //foreach (var  item in newList)
            //{
            //    Console.WriteLine(item.GetType().ToString());
            //}
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }



            Console.ReadLine();
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
            int a = 5;
            List<object> myResult = new List<object>();
            List<int> newList = new List<int>();
            
            //IEnumerable<int> results = new IEnumerable<int>();
            foreach (var item in listOfItems)
            {
                if (item.GetType() == a.GetType())
                {
                    newList.Add((int)item);
                }
                
            }
            return newList;
            
        }
    }
}
