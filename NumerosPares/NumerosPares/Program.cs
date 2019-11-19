using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {Console.Write("Informe um numero: ");
            var a = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Informe outro numero: ");
            var b = Int32.Parse(Console.ReadLine());
            Console.WriteLine();


            if (b < a)
            {
                var c = a;
                a = b;
                b = c;
            }

            for (int i = ++a; i < b; i++)
            {
                 if( i % 2 != 0 )
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        }
    }
}
