using System;
using static System.Console;

namespace Demos
{
    class Program
    {
        static int AdicionarDoisValores(int valor1, int valor2)
        {
            int soma = 0;
            soma = valor1 + valor2;

            return soma;
        }
        static void Main(string[] args)
        {
            int primeiroValor = 0;
            int segundoValor = 0;

            WriteLine();
            WriteLine("----- SOMANDO DOIS NÚMEROS INTEIROS -----");
            WriteLine();
            Write("Digite o primeiro valor..: ");
            primeiroValor = Convert.ToInt32(ReadLine());
            Write("Digite o segundo valor...: ");
            segundoValor = Convert.ToInt32(ReadLine());
            WriteLine();
            WriteLine($"A soma entre {primeiroValor} e {segundoValor} é {AdicionarDoisValores(primeiroValor,segundoValor)}");

            //Console.ReadKey();
        }
    }
}
