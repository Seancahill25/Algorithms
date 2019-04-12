using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 6, 5, 7, 2, 1, 6, 8 };
           
                Array.Sort(arr);
                for (var i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] == arr[i + 1])
                    {
                    Console.WriteLine(true); 
                    }
                }
                Console.WriteLine(false); 
        }
        
    }
}
