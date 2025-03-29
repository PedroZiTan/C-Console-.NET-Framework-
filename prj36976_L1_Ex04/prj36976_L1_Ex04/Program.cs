using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36976_L1_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {

            double b,a,t;

            Console.WriteLine("Digite a base: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            a = double.Parse(Console.ReadLine());

            t = (b * a) / 2;

            Console.WriteLine("A área do triângulo é: " + t);

        }
    }
}
