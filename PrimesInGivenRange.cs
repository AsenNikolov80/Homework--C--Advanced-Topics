using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            Console.Write("start number= ");
            int startNum = int.Parse(Console.ReadLine());
            Console.Write("end number= ");
            int endNum = int.Parse(Console.ReadLine());
            
            FindPrimesInRange(startNum, endNum);
        }

        static void FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primesInRange = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                bool prime = true;
                if (i % 2 == 0)
                {
                    prime = false; continue;
                }
                double maxDiv = Math.Sqrt(i);
                maxDiv = Convert.ToInt32(maxDiv);

                for (int j = 2; j <= maxDiv; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false; break;
                    }
                }
                if (prime)
                {
                    primesInRange.Add(i);
                }
            }
            int lengthPrime = primesInRange.Count;
            int k = 0;
            for (k = 0; k < lengthPrime - 1; k++)
            {
                Console.Write(primesInRange[k] + ", ");
            }
            Console.WriteLine(primesInRange[k]);
        }
    }
}
