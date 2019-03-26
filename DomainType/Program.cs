using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainType
{
    class Program
    {
         static void Main(string[] args)
        {
            string[] domains = new string[]
            {"com.net.info",
             "org.com.net",
             "net.com.org",
             "info.net.com",
             "net.net.com",
             "com.com.org",
             "info.info.net",
             "org.org.info"
            };

            foreach(var domain in DomainTypes(domains))
            {
                Console.WriteLine(domain);
            }
        
        }

       public static string[] DomainTypes(string[] domains)
        {

            List<string> list = new List<string>();

            foreach (var site in domains)
            {
                if (site.EndsWith("org"))
                {
                    list.Add("organization");
                }
                else if (site.EndsWith("com"))
                {
                    list.Add("commercial");
                }
                else if (site.EndsWith("net"))
                {
                    list.Add("network");
                }
                else if (site.EndsWith("info"))
                {
                    list.Add("information");
                }
            }
            return list.ToArray();
        }

    }


}
