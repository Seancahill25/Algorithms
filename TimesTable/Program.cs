using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesTable
{
    class Solution
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (var i = 1; i <= 10; i++)
            {

                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }

        }
    }
}
