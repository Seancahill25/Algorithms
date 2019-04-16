using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 10, 20, 30, 40 }; 
            int v = 42;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] + b[j] == v)
                    {
                        Console.WriteLine(true);
                    } 
                }
            }
            Console.WriteLine(false);
        }
    }
}
