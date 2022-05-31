using System;
using static System.Console;

namespace Aula_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero a = new Numero(2);
            Numero b = new Numero(2);

            if(a.N == b.N)
            {
                WriteLine("a é igual a b");
            }
            else
            {
                WriteLine("a é diferente de b");
            }
        }
    }

    class Numero
    {
        public int N { get; set; }

        public Numero(int n)
        {
            N = n;
        }
    }
}
