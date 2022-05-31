using System;
using static System.Console;
using System.Collections.Generic;

namespace Demos
{
    class Program
    {
        static void Demo1()
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

        static void Demo2()
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "Ricardo";
            p1.Idade = 30;
            p1.Documento = "1234";

            Pessoa p2 = p1.Clone();

            TrocarNome(p1, "José");

            WriteLine($@"
            O nome p1 é: {p1.Nome}
            O nome p2 é: {p2.Nome}
            ");
        }

        static void Demo3()
        {
            StructPessoa p1 = new StructPessoa()
           {
               Documento = "1234",
               Idade = 30,
               Nome = "Ricardo"
           };

           var p2 = p1;
 
           TrocarNome(p1, "José");

           WriteLine($@"
            O nome p1 é: {p1.Nome}
            O nome p2 é: {p2.Nome}
            ");
        }

        static void Demo4()
        {
            string nome = "Forest";

            TrocarNome(nome, "José");

            WriteLine($"O novo nome é {nome}");
        }

        static void Demo5()
        {
            int[] pares = new int[]{0,2,4,6,8};

            MudarParaImpar(pares);

            WriteLine($"Os ímpares {string.Join(",", pares)}");
        }

        static void Demo6()
        {
            int [] numeros = new int[]{0, 2, 4, 6, 8};
            Write($"Digite o número que gostaria de encontrar: ");
            var numero = int.Parse(ReadLine());
            var idxEncontrado = EncontrarNumero(numeros, numero);

            if(idxEncontrado >= 0)
            {
                WriteLine($"O número digitado está na posição {idxEncontrado}");
            }
            else
            {
                WriteLine($"O número digitado não foi encontrado");
            }
        }

        static void Demo7()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            {
                new Pessoa(){Nome = "Ricardo"};
                new Pessoa(){Nome = "José"};
                new Pessoa(){Nome = "Maria"};
                new Pessoa(){Nome = "Fabiana"};
                new Pessoa(){Nome = "Eduardo"};

            };

            Write($"Digite o nome da pessoas que gostaria de localizar:");
            var nome = ReadLine();
            var pessoa = new Pessoa(){Nome = nome};
            var encontrado = EncontrarPessoa(pessoas, pessoa);

            if(encontrado)
            {
                WriteLine($"Pessoa localizada!");
            }
            else
            {
                WriteLine("Pessoa não localizada!");
            }
        }

        static void Demo8()
        {
            //criando uma lista
            List<StructPessoa> pessoas = new List<StructPessoa>();
            {
                new StructPessoa(){Nome = "Ricardo"};
                new StructPessoa(){Nome = "José"};
                new StructPessoa(){Nome = "Maria"};
                new StructPessoa(){Nome = "Fabiana"};
                new StructPessoa(){Nome = "Eduardo"};

            };

            Write($"Digite o nome da pessoa que gostaria de localizar: ");
            var nome = ReadLine();
            var pessoa = new StructPessoa(){Nome = nome};
            var encontrado = EncontrarPessoa(pessoas, pessoa);

            if(encontrado)
            {
                WriteLine($"Pessoa localizada!");   
            }
            else
            {
                WriteLine("Pessoa não localizada!");
            }
        }
        
        static int AdicionarDoisValores(int valor1, int valor2)
        {
            int soma = 0;
            soma = valor1 + valor2;

            return soma;
        }

        static void TrocarNome(Pessoa p1, string novoNome)
        {
            p1.Nome = novoNome;
        }

        static void TrocarNome(StructPessoa p1, string NomeNovo)
        {
            p1.Nome = NomeNovo;
        }

        static void TrocarNome(string nome, string NomeNovo)
        {
            nome = NomeNovo;
        }

        static void MudarParaImpar(int[] pares)
        {
            for (int i = 0; i < pares.Length; i++)
            {
                pares[i] = pares[i] + 1;
            }
        }

        static int EncontrarNumero(int[] numeros, int numero)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if(numeros[i] == numero)
                {
                    return i;
                }
            }
            return -1;
        }

        static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
        {
            foreach (var item in pessoas)
            {
                if(item.Nome == pessoa.Nome)
                {
                    return true;
                }
            }
            return false;
        }

        static bool EncontrarPessoa(List<StructPessoa> pessoas, StructPessoa pessoa)
        {
            foreach (var item in pessoas)
            {
                if(item.Equals(pessoa))
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
