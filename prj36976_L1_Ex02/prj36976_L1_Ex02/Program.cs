using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36976_L1_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declaração das variáveis
            double a; // Aresta
            double area; // Área

            // adicionar display
            Console.WriteLine("Digite a aresta:");

            // Input manual 
            a = Convert.ToDouble(Console.ReadLine());

            // calculo
            area = a * a;

            // display 
            Console.WriteLine("A área é: " + area);

            // Fim

        }
    }
}
