using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diferença
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f, i, o, p;
            Console.WriteLine("Digite o primeiro valor : ");
            f = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor: ");
            o = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto valor ");
            p = int.Parse(Console.ReadLine());

            int dif = (f * i - o * p);
            Console.WriteLine("A diferença entre o produto F e I é de: " + dif);


        }

    }
}
