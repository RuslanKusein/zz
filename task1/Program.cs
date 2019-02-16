using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1
{
    class Program
    {
        static bool f(int n)//создал булевую функцию чтобы проверить n прайм или не прайм
        {
            bool k = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    k = false;
                    break;
                }
            }
            return k;
        }
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] nums = Console.ReadLine().Split();

            int sum = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                a[i] = int.Parse(nums[i]);
            }
            for (int i = 0; i < a.Length; ++i)//если число равно 1 или число который зашел в булевую функцию false то a[i]=0
            {
                if (a[i] == 1) a[i] = 0;
                if (f(a[i]) == true && a[i]!=0)//a[i]!=0 потому что если число 1 то a[i]=0 и когда он заходит в булевую функцию он будет равен тру из за этого надо пофиксить
                {
                    sum++;
                }
                else a[i] = 0;
            }
            Console.WriteLine(sum);

            for (int i = 0; i < n; i++)
            {
                if (a[i] != 0) Console.Write(a[i] + " ");
            }
            Console.ReadKey();
        }

    }
}