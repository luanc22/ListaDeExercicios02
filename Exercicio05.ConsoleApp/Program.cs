using System;

namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // linhas 9 a 13 = inicio e condicao do while para rodar o programa ate que o usuario deseje parar.

            bool fecharApp = false;

            while (fecharApp == false)
            {
                // linhas 17 a 30 = input de dados, conversao de tipos de dados para utilizacao e declaracao de variaveis utilizadas.

                Console.WriteLine("===== Checar Numeros Inteiros =====");
                Console.WriteLine("");
                Console.WriteLine("Programa para identificar se dois numeros inteiros sao iguais.");
                Console.WriteLine("");

                Console.Write("Digite o primeiro numero que sera o valor de A: ");
                string inputNumOne = Console.ReadLine();
                Console.Write("Digite o segundo numero que sera o valor de B: ");
                string inputNumTwo = Console.ReadLine();

                int numOneA = int.Parse(inputNumOne);
                int numTwoB = int.Parse(inputNumTwo);

                Console.WriteLine("");

                // linhas 34 a 51 = condicoes para cada situacao + output do resultado.

                if (numOneA == numTwoB)
                {
                    int somaNumC = numOneA + numTwoB;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ambos os valores de A e B sao iguais, entao a soma deles no valor de C fica: {0}.", somaNumC);
                    Console.ResetColor();
                }
                else
                {
                    int multNumC = numOneA * numTwoB;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A e B tem valores diferentes, entao sua multiplicacao no valor de C fica: {0}.", multNumC);
                    Console.ResetColor();
                }

                Console.WriteLine("");
                Console.WriteLine("Aperte ENTER para prosseguir.");
                Console.ReadLine();

                // linhas 55 a 85 = inicio e condicao do while de menu de escolha do usuario para sair da aplicao ou permanecer rodando a mesma.

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
