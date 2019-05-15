using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItLucky
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1230;
            int input2 = 239017;
            int input3 = 134008;

            Console.WriteLine(isLucky(input));
            Console.WriteLine(isLucky(input2));
            Console.WriteLine(isLucky(input3));
        }

        static bool isLucky(int n)
        {
            string N = n.ToString();
            int secondHalf = N.Length / 2;
            var sum = 0;
            var sum2 = 0;
            for (var i = 0; i < N.Length / 2; i++, secondHalf++)
            {
                sum += N[i];
                sum2 += N[secondHalf];
            }
            if (sum == sum2)
            {
                return true;
            }
            return false;
        }
    }
}
