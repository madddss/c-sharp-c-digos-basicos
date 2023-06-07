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
            float notadeexame, mediaFinal;
            string[] val = Console.ReadLine().Split(' ');
            float notas = 0;
            float N1 = float.Parse(val[0]);
            float N2 = float.Parse(val[1]);
            float N3 = float.Parse(val[2]);
            float N4 = float.Parse(val[3]);
            notas = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;


            if (notas >= 7.0)
            {
                Console.WriteLine(" Aluno aprovado. ");
            }
            else if (notas < 5.0)
            {
                Console.WriteLine(" Aluno reprovado. ");
            }

            else
                Console.WriteLine("Aluno em exame");
            notadeexame = float.Parse(Console.ReadLine());
            mediaFinal = (notas * notadeexame) / 2;
            Console.WriteLine("Nota do exame " + notadeexame.ToString("F1", CultureInfo.InvariantCulture));
            if (mediaFinal >= 50)
            {
                Console.WriteLine("Aluno aprovado");

            }
            else
            {
                Console.WriteLine("Aluno reprovado ");
            }

        }
    }
}
