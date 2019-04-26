using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = new int[]{ 3, 6, -2, -5, 7, 3 };
                int product = int.MinValue;
                for (int i = 0; i < inputArray.Length - 1; i++)
                {
                    if (inputArray[i] * inputArray[i + 1] > product)
                    {
                        product = inputArray[i] * inputArray[i + 1];
                    }
                }
            Console.WriteLine(product);
        }
    }
}
