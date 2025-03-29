using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36976_L1_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {

            //adicionar as variaveis
            double a, d;

            //adicionar o display
            Console.WriteLine("Digite a diagonal: ");

            //input manual
            d = double.Parse(Console.ReadLine());

            //calculo
            a = (d * d) / 2;

            //display
            Console.WriteLine("A área é: " + a);

            //Fim

        }
    }
}
