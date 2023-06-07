using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace diferença
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu número? ");
            int numerofun = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas horas vc trabalhou? ");
            int horastrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto vc recebe por hora? ");
            double valorporhora = double.Parse(Console.ReadLine());

            double salario = horastrabalhadas * valorporhora;

            Console.WriteLine("Seu salário é de: $ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}
