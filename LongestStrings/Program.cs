using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = { "aba", "aa", "ad", "vcd", "aba" };
            string[] inputArray2 = { "young", "yooooooung", "hot", "or", "not", "come", "on", "fire", "water", "watermelon" };

            foreach(string input in allLongestStrings(inputArray))
            {
                Console.WriteLine(input);
            }
            Console.WriteLine();
            foreach(string input in allLongestStrings(inputArray2))
            {
                Console.WriteLine(input);
            }
        }

        static string[] allLongestStrings(string[] inputArray)
        {
            List<string> newArray = new List<string>();
            int stringLength = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length > stringLength)
                {
                    stringLength = inputArray[i].Length;
                }
            }
            foreach (string input in inputArray)
            {
                if (input.Length == stringLength)
                {
                    newArray.Add(input);
                }
            }
            return newArray.ToArray();
        }

    }
}
