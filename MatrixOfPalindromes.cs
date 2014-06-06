using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MatrixOfPalindromes
{
    static void Main()
    {
        Console.Write("enter rows r= ");
        int r = int.Parse(Console.ReadLine());
        Console.Write("enter rows c= ");
        int c = int.Parse(Console.ReadLine());
        char novo = 'a';

        for (int i = 0; i < r; i++)
        {

            for (int j = 0; j < c; j++)
            {
                char nextNovo = Convert.ToChar(novo + j);
                
                Console.Write("{0}{1}{0} ", novo, nextNovo);
                
            }
            Console.WriteLine();
            novo++;
        }

    }
}
