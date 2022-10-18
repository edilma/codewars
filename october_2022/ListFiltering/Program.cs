using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFiltering
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> test = new List<object>{ 1, 2, "a", "b", "aasf", "1", "123", 231 };
            var result = GetIntegersFromList(test);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            
        }
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            //var query = listOfItems.OfType<int>();
          return listOfItems.OfType<int>();



        }
       
    }
}
