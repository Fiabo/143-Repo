using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProj
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var c = new Context())
            {
                var q = c.Good
                    .Where(b => b.name.StartsWith("G"))
                    .ToList();

                foreach (var item in q)
                    Console.WriteLine(item.name);
            }
        }
    }
}
