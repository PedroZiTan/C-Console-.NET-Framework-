using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36976_L1_Ex09
{
    class Program
    {
        static void Main(string[] args)
        {

            double t, r, c;

            Console.WriteLine("Digite a resistencia: ");
            r = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Corrente: ");
            c = double.Parse(Console.ReadLine());

            t = r * c;

            Console.WriteLine("A tensão é: " + t);

        }
    }
}
