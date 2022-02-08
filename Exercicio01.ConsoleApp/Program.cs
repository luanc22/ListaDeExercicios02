using System;

namespace Exercicio01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // linhas 9 a 13 = inicio e condicao do while para rodar o programa ate que o usuario deseje parar.

            bool fecharApp = false;

            while (fecharApp == false)
            {
                // linhas 17 a 36 = input de dados, conversao de tipos de dados para utilizacao e declaracao de variaveis utilizadas.

                Console.WriteLine("===== Checar soma =====");
                Console.WriteLine("");
                Console.WriteLine("Programa para calcular se a soma de A + B resulta menor que C.");
                Console.WriteLine("");

                Console.Write("Digite o valor de A: ");
                string inputA = Console.ReadLine();
                int inputANum = int.Parse(inputA);

                Console.Write("Digite o valor de B: ");
                string inputB = Console.ReadLine();
                int inputBNum = int.Parse(inputB);

                Console.Write("Digite o valor de C: ");
                string inputC = Console.ReadLine();
                int inputCNum = int.Parse(inputC);

                int somaAB = inputANum + inputBNum;

                Console.WriteLine("");

                // linhas 40 a 68 = condicoes para cada situacao + output do resultado.

                if (somaAB < inputCNum)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("A soma de A e B fica menor que C, pois {0} < {1}.", somaAB, inputCNum);
                    Console.ResetColor();
                    Console.WriteLine("Soma de AB: {0}.", somaAB);
                    Console.WriteLine("Valor de C: {0}.", inputCNum);
                }
                else if (somaAB == inputCNum)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("A soma de A e B tem o mesmo valor de C, pois {0} = {1}.", somaAB, inputCNum);
                    Console.ResetColor();
                    Console.WriteLine("Soma de AB: {0}.", somaAB);
                    Console.WriteLine("Valor de C: {0}.", inputCNum);

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A soma de A e B fica maior que C, pois {0} > {1}.", somaAB, inputCNum);
                    Console.ResetColor();
                    Console.WriteLine("Soma de AB: {0}.", somaAB);
                    Console.WriteLine("Valor de C: {0}.", inputCNum);
                }

                Console.WriteLine("");
                Console.WriteLine("Aperte ENTER para prosseguir.");
                Console.ReadLine();

                // linhas 72 a 102 = inicio e condicao do while de menu de escolha do usuario para sair da aplicao ou permanecer rodando a mesma apos o uso.

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
                        Console.ForegroundColor= ConsoleColor.Red;
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
