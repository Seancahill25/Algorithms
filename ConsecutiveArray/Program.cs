using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecutiveArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] statues = { 6, 2, 3, 8 };       
            Console.WriteLine(makeArrayConsecutive2(statues));
        }

        public static int makeArrayConsecutive2(int[] statues)
        {
            return statues.Max() - statues.Min() - statues.Length + 1;
        }
    }
}
//arrange the statues from smallest to largest,so that each statue will be bigger than the previous one exactly by 1.
//figure out the minimum number of additional statues needed.
