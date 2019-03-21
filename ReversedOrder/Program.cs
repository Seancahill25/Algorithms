using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(ReversedOrder(num));
        }

        public static int ReversedOrder(int num)
        {
            int reverse = 0;

            while (num != 0)
            {
                reverse = reverse * 10 + num % 10;
                num /= 10;
            }
            return reverse;
        }
    }
}
