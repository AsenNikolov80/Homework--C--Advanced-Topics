using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Fib(n);
        }

        static void Fib(int n)
        {
            int n1 = 0; int n2 = 1; int nextNumber=0;
            for (int i = 1; i <= n; i++)
            {
                nextNumber = n1 + n2;
                n1 = n2;
                n2 = nextNumber;
                
            }
            Console.WriteLine(nextNumber);
        }
    }
}
