using System;

namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // linhas 9 a 13 = inicio e condicao do while para rodar o programa ate que o usuario deseje parar.

            bool fecharApp = false;

            while (fecharApp == false)
            {
                // linhas 17 a 28 = input de dados, conversao de tipos de dados para utilizacao e declaracao de variaveis utilizadas.

                Console.WriteLine("===== Calcular Par ou Impar =====");
                Console.WriteLine("");
                Console.WriteLine("Programa para calcular se um numero eh par ou impar.");
                Console.WriteLine("");

                Console.Write("Digite um numero: ");
                string inputNum = Console.ReadLine();

                double numParImp = double.Parse(inputNum);
                double condParImp = numParImp % 2;

                Console.WriteLine("");

                // linhas 32 a 47 = condicoes para cada situacao + output do resultado.

                if (condParImp == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("O numero {0} eh um numero par.", numParImp);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("O numero {0} eh um numero impar.", numParImp);
                    Console.ResetColor();
                }

                Console.WriteLine("");
                Console.WriteLine("Aperte ENTER para prosseguir.");
                Console.ReadLine();

                // linhas 51 a 81 = inicio e condicao do while de menu de escolha do usuario para sair da aplicao ou permanecer rodando a mesma apos o uso.

                bool opcaoValida = false;

                while (opcaoValida == false)
                {
                    Console.WriteLine("Caso deseje realizar outra operacao, digite 1 e aperte ENTER.");
                    Console.WriteLine("Caso deseje fechar o programa, digite 0 e aperte ENTER.");
                    Console.Write("Opcao escolhida: ");
                    string fecharBotao = Console.ReadLine();

                    if (fecharBotao == "0")
                    {
                        fecharApp = true;
                        opcaoValida = true;
                    }
                    else if (fecharBotao == "1")
                    {
                        Console.Clear();
                        opcaoValida = true;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opcao invalida, selecione uma opcao valida!");
                        Console.ResetColor();
                        Console.WriteLine("");
                        Console.WriteLine("Aperte ENTER para prosseguir.");
                        Console.ReadLine();
                        continue;
                    }
                }
            }
        }
    }
}
