using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36976_L1_Ex05
{
    class Program
    {
        static void Main(string[] args)
        {

            double v, d, r;

            Console.WriteLine("Digite o diametro: ");
            d = double.Parse(Console.ReadLine());

            v = d / 2;
            r = (4 * 3.14) * v / 3;

            Console.WriteLine("O volume é: " + r);

        }
    }
}
