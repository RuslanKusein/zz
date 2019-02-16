using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 1; i <= n; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
/*[*]
[*][*]
[*][*][*]*/

