using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Given a base-10 integer,n, convert it to binary (base-2). 
//Then find and print the base-10 integer denoting the maximum number of consecutive 1's in n's binary representation.
namespace ConsecutiveBinary
{
    class Solution
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(n, 2);

            string[] binary1 = binary.Split('0');
            Console.WriteLine(binary1.Max().Length);
        }
    }
}
