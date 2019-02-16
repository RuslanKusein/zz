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
            int[] a = new int[n];//massiv a[n] kotoryi budet sohranyat te 4isla kotorie ti daesh;
            int[] b = new int[n * 2];//massiv b[n] kotoryi sohranyet 1 1 2 2...;
            string[] nums = Console.ReadLine().Split();

            for (int i = 0; i < n; ++i)
            {
                a[i] = int.Parse(nums[i]);
            }
            int j = 0;//sozdau 4islo,potomu 4to v massive b ya dolzhen povtoryat 4islo 2 raz,t.e kajdomu 4islu nujna 2 mesta poetomu v konce for ya delau ++j ++j;
            for (int i = 0; i < n; ++i)
            {
                b[j] = a[i];
                b[j + 1] = a[i];
                ++j; ++j;
            }
            for (int i = 0; i < n * 2; ++i)
            {
                Console.Write(b[i] + " ");
            }
            Console.ReadKey();
        }
    }
}