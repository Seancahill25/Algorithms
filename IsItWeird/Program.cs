using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItWeird
{

//If  n is odd, print Weird
//If  n is even and in the inclusive range of  to , print Not Weird
//If  n is even and in the inclusive range of  to , print Weird
//If   n is even and greater than, print Not Weird
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 != 0 || N >= 6 & N <= 20)
            {
                Console.WriteLine("Weird");
            }
            else if (N % 2 == 0 && N >= 2 & N <= 5 || N > 20)
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
