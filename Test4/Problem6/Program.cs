using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Problem6
    {
        // this method finds odd numbers that are squares of the numbers in the input list
        public static IEnumerable<int> findOdds(IEnumerable<int> input)
        {
            IEnumerable<int> result;

            result = input.Select(x => x * x).Where(x => x % 2 != 0);

            return result;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers3 = { -5, -6, -7, -8, 47, 50, 60, 1000, 2000, 3000 };

            List<int> list = numbers3.OfType<int>().ToList();

            var answer = Problem6.findOdds(list);

            foreach (int i in answer)
            {
                Console.WriteLine(i);
            }
    
        }
    }
}

