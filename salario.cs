using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aluno_aprovado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sal;
            double percentual = 0;
            Console.WriteLine("Qual o seu sálario? ");
            sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (sal <= 400.00)

            {
                percentual = 15.0;
            }
            else if (sal <= 800.00)

            {
                percentual = 12.0;

            }
            else if (sal <= 1200.00)

            {

                percentual = 10.0;

            }

            else if (sal <= 2000.00)

            {
                percentual = 7.0;

            }
            else if (sal > 2000.00)
            {
                percentual = 4.0;
            }

            double reajuste = sal * percentual / 100.0;
            double novosal = sal + reajuste;

            Console.WriteLine("Novo sálario: " + novosal.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual.ToString(" F0 ", CultureInfo.InvariantCulture) + " % ");

        }
    }
}
