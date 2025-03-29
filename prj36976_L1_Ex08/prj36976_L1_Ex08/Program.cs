using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36976_L1_Ex08
{
    class Program
    {
        static void Main(string[] args)
        {

            double m, v;

            Console.WriteLine("Digite a milhas: ");
            m = double.Parse(Console.ReadLine());

            v = (m * 1852) / 1000;

            Console.WriteLine("Valor em km é: " + v);

        }
    }
}
