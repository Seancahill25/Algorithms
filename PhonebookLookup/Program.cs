using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookLookup
{
    class Solution
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var phonebook = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var split = Console.ReadLine().Split(' ');
                phonebook.Add(split[0], split[1]);
            }

            for (int i = 0; i < n; i++)
            {
                var query = Console.ReadLine();
                if (phonebook.ContainsKey(query))
                {
                    Console.WriteLine(query + "=" + phonebook[query]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }

}
