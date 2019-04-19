using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItPrime
{
    class Program
    {
        public static bool isPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(String[] args)
        {
            var inputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputs; i++)
            {
                int values = int.Parse(Console.ReadLine());

                if (values >= 2 && isPrime(values))
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
                }
            }
        }
    }
}
