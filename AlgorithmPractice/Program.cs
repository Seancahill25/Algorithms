using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculater
{
    class Solution
    {

        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            var tax = meal_cost * tax_percent / 100;
            var tip = meal_cost * tip_percent / 100;

            Console.WriteLine(Math.Round(meal_cost + tax + tip));

        }

        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);
        }
    }

}
