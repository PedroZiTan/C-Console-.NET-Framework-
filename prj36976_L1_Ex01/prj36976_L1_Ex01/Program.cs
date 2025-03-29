using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36976_L1_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração das variáveis
            double base_x;
            double altura;
            double area;

            // Solicita ao usuário que digite o valor da base
            Console.Write("Digite o valor da base: ");
            base_x = Convert.ToDouble(Console.ReadLine());

            // Solicita ao usuário que digite o valor da altura
            Console.Write("Digite o valor da altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            // Cálculo da área
            area = base_x * altura;

            // Exibição do resultado
            Console.WriteLine("A área é: " + area);

        }
    }
}
