using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptional
{
    class Solution
    {

        static void Main(String[] args)
        {
            string S = Console.ReadLine();

            try
            {
                Console.WriteLine(int.Parse(S));
            }
            catch (Exception)
            {
                Console.WriteLine("Bad String");
            }
        }
    }

}
