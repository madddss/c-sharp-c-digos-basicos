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
            //1114
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {

                Console.WriteLine("Senha inválida");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Senha válida");

        }
    }   } 

