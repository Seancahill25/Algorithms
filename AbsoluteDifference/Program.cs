using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteDifference
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] arr)
        {
            elements = arr;
        }

        public void computeDifference()
        {
            Array.Sort(elements);
            maximumDifference = Math.Abs(elements[0] - elements[elements.Length - 1]);
        }
    } 

    class Solution
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}
