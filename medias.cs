using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5
            double j, k;

            Console.WriteLine("Digite a primeira nota: ");
            j = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            k = double.Parse(Console.ReadLine());

            double media = (j + k) / 2;

            Console.WriteLine("MEDIA = " + media.ToString("F3", CultureInfo.InvariantCulture));

            //6 
            double c, d, e;
            Console.WriteLine("Digite a primeira nota: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            d = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            e = double.Parse(Console.ReadLine());

            double med = ((c * 2) + (d * 3) + (e * 5)) / 3;
            Console.WriteLine("MEDIA = " + med.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
