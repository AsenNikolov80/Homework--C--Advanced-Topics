using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingNumbers
{
    class SortingNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers=new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("next number= ");
                int novo=int.Parse(Console.ReadLine());
                numbers[i] = novo;
            }
            Array.Sort(numbers);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
