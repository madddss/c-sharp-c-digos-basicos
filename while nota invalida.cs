using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota1 < 0.0 || nota1 > 10.0)
            {
                Console.WriteLine("Nota Inválida");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota2 < 0.0 || nota2 > 10.0)
            {
                Console.WriteLine("Nota inválida");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double media = (nota1 + nota2) / 2;
            Console.WriteLine("media: " + media.ToString(CultureInfo.InvariantCulture));
        }
    }   } 

