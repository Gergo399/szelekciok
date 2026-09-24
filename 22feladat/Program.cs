using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy számot: ");
            int szam1= int.Parse(Console.ReadLine());
            if (szam1%3==0)
            {
                Console.WriteLine("A szám osztható 3-al");
            }
            else
            {
                Console.WriteLine("A szám nem osztható hárommal");
            }
            Console.ReadKey();
        }
    }
}
