using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfNames
{
    class CountOfNames
    {
        static void Main()
        {
            Console.Write("enter first list: ");
            string first = Console.ReadLine();
            List<string> firstList = new List<string>(first.Split(' '));
            firstList.Sort(); int counter = 1;
            Dictionary<string, int> result = new Dictionary<string, int>();
            for (int i = 0; i < firstList.Count; i++)
            {
                if (i == firstList.Count - 1)
                {
                    result[firstList[i]] = counter; break;
                }
                if (firstList[i] == firstList[i + 1])
                {
                    counter++;
                }
                else
                {
                    result[firstList[i]] = counter; counter = 1;
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }


        }
    }
}
