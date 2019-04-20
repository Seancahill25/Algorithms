using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFineCalculator
{
    class Program
    {
        static void Main(String[] args)
        {
            string userInput = Console.ReadLine();
            string[] actualDate = userInput.Split(' ');
            int actualDay = Convert.ToInt32(actualDate[0]);
            int actualMonth = Convert.ToInt32(actualDate[1]);
            int actualYear = Convert.ToInt32(actualDate[2]);

            string userInput2 = Console.ReadLine();
            string[] expectedDate = userInput2.Split(' ');
            int expectedDay = Convert.ToInt32(expectedDate[0]);
            int expectedMonth = Convert.ToInt32(expectedDate[1]);
            int expectedYear = Convert.ToInt32(expectedDate[2]);
            int fine;

            if (actualYear > expectedYear)
            {
                fine = 10000;
            }
            else if (actualMonth > expectedMonth && (actualYear >= expectedYear))
            {
                fine = 500 * (actualMonth - expectedMonth);
            }
            else if (actualDay > expectedDay && (actualMonth >= expectedMonth) && (actualYear >= expectedYear))
            {
                fine = 15 * (actualDay - expectedDay);
            }
            else
            {
                fine = 0;
            }
            Console.WriteLine(fine);
        }
    }
}
