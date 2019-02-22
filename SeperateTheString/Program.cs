using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given a string,S, of length N that is indexed from 0 to N-1, 
//print its even-indexed and odd-indexed characters as  space-separated strings on a single line.

namespace SeperateTheString
{
    class Solution
    {
        static void Main(String[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            string[] s1 = new string[T];

            int i = 0;
            while (i < T)
            {
                string s = Console.ReadLine();
                s1[i++] = s;
            }

            i = 0;
            while (i < T)
            {
                char[] c1 = s1[i].ToCharArray();
                string even = "";
                string odd = "";
                for (int j = 0; j < c1.Length; j++)
                {
                    if (j % 2 == 0) even += c1[j];
                    if (j % 2 != 0) odd += c1[j];
                }
                Console.WriteLine("{0} {1}", even, odd);
                i++;
            }
        }
    }
}
