using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosImparesEntre100e200
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int nu = 100; nu < 201; nu++) {
                if (nu % 2 != 0) {
                    Console.WriteLine(nu);
                }
            }
           
        }
    }
}
