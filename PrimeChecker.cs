using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            UInt64 n1 = UInt64.Parse(Console.ReadLine());
            IsPrime(n1);
        }


        static void IsPrime(UInt64 n1)
        {
            if (n1 % 2 == 0)
            {
                Console.WriteLine("{0} is not a prime", n1);
            }
            else
            {
                UInt64 n = Convert.ToUInt64(n1);
                double maxDivider = Math.Sqrt(n);
                UInt64 maxDiv = Convert.ToUInt64(maxDivider);
                bool prime = true;
                for (UInt64 i = 3; i <= maxDiv; i++)
                {
                    if (n % i == 0)
                    {
                        prime = false; break;
                    }
                }
                Console.WriteLine(prime);
            }
        }
    }
}
