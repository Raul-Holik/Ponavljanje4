using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje4.D._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Upišite stranicu x");
            x = Convert.ToInt32(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("Vrijednost mora biti veća od nule");
            }

            Console.WriteLine("Upišite stranicu y");
            y = Convert.ToInt32(Console.ReadLine());
            if (y == 0)
            {
                Console.WriteLine("Vrijednost mora biti veća od nule");
            }
            Console.WriteLine("Upišite stranicu z");
            z = Convert.ToInt32(Console.ReadLine());
            if (z == 0)
            {
                Console.WriteLine("Vrijednost mora biti veća od nule");
            }

            if (Math.Pow(z, 2) < Math.Pow(x, 2) + Math.Pow(y, 2)) 
            {
                Console.WriteLine("To su stranice pravokutnog trokuta");
            }
            
            else
            {
                Console.WriteLine("To nisu stranice trokuta");
            }
            Console.ReadKey();
        }  
    }
}
