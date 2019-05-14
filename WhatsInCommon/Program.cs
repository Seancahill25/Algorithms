using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsInCommon
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "aabcc";
            string s2 =" adcaa";
            string s3 = "zzzz";
            string s4 = "zzzzzzz";

            Console.WriteLine(commonCharacterCount(s1, s2));
            Console.WriteLine(commonCharacterCount(s3, s4));
        }

        static int commonCharacterCount(string s1, string s2)
        {
            List<char> list1 = s1.ToList();
            List<char> list2 = s2.ToList();
            int count = 0;

            foreach (char c in list2)
            {
                if (list1.Contains(c))
                {
                    list1.Remove(c);
                    count++;
                }
            }
            return count;
        }

    }
}
