using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj36976_L1_Ex10
{
    class Program
    {
        static void Main(string[] args)
        {

            double c, f;

            Console.WriteLine("Digita o valor em graus Celsius: ");
            c = double.Parse(Console.ReadLine());

            f = (9.0 / 5)* c + 32;
            
            Console.WriteLine("O valor em F é: " + f);

        }
    }
}
