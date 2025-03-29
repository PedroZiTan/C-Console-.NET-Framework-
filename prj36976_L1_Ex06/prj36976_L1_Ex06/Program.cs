using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36976_L1_Ex06
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, p1, p2, p3, p4;

            Console.WriteLine("Digite o 1° numero: ");
            p1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2° numero: ");
            p2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 3° numero: ");
            p3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 4° numero: ");
            p4 = double.Parse(Console.ReadLine());

            a = (p1 + p2 + p3 + p4) / 4;

            Console.WriteLine("A média dos números é: " + a);
        }
    }
}
