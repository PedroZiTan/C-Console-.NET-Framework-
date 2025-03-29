using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36976_L1_Ex07
{
    class Program
    {
        static void Main(string[] args)
        {

            double media, p1, p2, raizQuadrada;

            Console.WriteLine("Digite o primeiro número: ");
            p1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            p2 = double.Parse(Console.ReadLine());

            media = p1 * p2;
            raizQuadrada = Math.Sqrt(media);

            Console.WriteLine("A média é: " + raizQuadrada);

        }
    }
}
