using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int cod1, cod2, numunidade1, numunidade2;
            double preçoproduto1, preçoproduto2, valortotal;

            string[] valores = Console.ReadLine().Split(',');
            cod1 = int.Parse(valores[0]);
            numunidade1 = int.Parse(valores[1]);
            preçoproduto1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            string[] vlr = Console.ReadLine().Split(',');
            cod2 = int.Parse(valores[3]);
            numunidade2 = int.Parse(valores[4]);
            preçoproduto2 = double.Parse(valores[5], CultureInfo.InvariantCulture);


            valortotal = preçoproduto1 * numunidade1 + preçoproduto2 * numunidade2;
            Console.WriteLine("VALOR A PAGAR: $ " + valortotal.ToString( "F2", CultureInfo.InvariantCulture));
        }
    }
}
