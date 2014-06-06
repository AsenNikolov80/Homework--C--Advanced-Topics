using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LongestAreaInArray
{
    static void Main(string[] args)
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        string[] strings = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("next element= ");
            strings[i] = Console.ReadLine();
        }
        int counter = 1;
        Dictionary<string, int> listOfRepeats = new Dictionary<string, int>();
        string nextElement = strings[0];
        for (int i = 1; i <= n; i++)
        {
            if (i == n)
            {
                listOfRepeats[strings[i - 1]] = counter;
            }
            else
            {
                if (strings[i] == nextElement)
                {
                    counter++; listOfRepeats[strings[i]] = counter;
                }
                else
                {
                    listOfRepeats[nextElement] = counter; counter = 1;
                }
                nextElement = strings[i];
            }
        }
        int maximumValue = listOfRepeats.Values.Max();
        int countValues = 0;
        string previousKey;
        previousKey = listOfRepeats.Keys.First();
        foreach (var item in listOfRepeats)
        {

            if (countValues > 0)
            {
                break;
            }
            if (item.Value == maximumValue)
            {
                countValues++; previousKey = item.Key;
            }
        }
        Console.WriteLine(maximumValue);
        for (int i = 0; i < maximumValue; i++)
        {
            Console.WriteLine(previousKey);
        }
    }
}

