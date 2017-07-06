using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n: ");
            int[] M = new int[10];
            int n = Convert.ToInt32(Console.ReadLine());
            int a;
            int i;


            while (n > 0)
            {
                n = Math.DivRem(n, 10, out a);
                M[a]++;
            }
            for (i = 0; i < M.Length; i++)
                Console.WriteLine("{0}: {1}", i, M[i]);
            Console.ReadKey();
        }
    }
}