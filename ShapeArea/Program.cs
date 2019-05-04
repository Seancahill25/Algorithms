using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(2 * n * (n - 1) + 1);
        }
    }
}
//An n-interesting polygon is obtained by taking the 
//n - 1-interesting polygon and appending 1-interesting 
//polygons to its rim, side by side.