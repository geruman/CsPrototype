using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Sheep dolly = new Sheep("Dolly","Red");
            Console.WriteLine(dolly);
            Sheep clone = dolly.Clone();
            Console.WriteLine(clone);
            Sheep clone2 = clone.Clone();
            Console.WriteLine(clone2);
            Console.ReadKey();
        }
    }
}
