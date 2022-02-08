using System;

namespace Exercicio01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool fecharApp = false;

            while (fecharApp == false)
            {
                Console.WriteLine("===== Checar soma =====");
                Console.WriteLine("");
                Console.WriteLine("Programa para calcular se a soma de A + B resulta menor que C.");
                Console.WriteLine("");

                Console.Write("Digite o valor de A: ");
                string inputA = Console.ReadLine();
                int inputANum = int.Parse(inputA);
                Console.WriteLine("");

                Console.Write("Digite o valor de B: ");
                string inputB = Console.ReadLine();
                int inputBNum = int.Parse(inputB);
                Console.WriteLine("");

                Console.Write("Digite o valor de C: ");
                string inputC = Console.ReadLine();
                int inputCNum = int.Parse(inputC);
                Console.WriteLine("");

                int somaAB = inputANum + inputBNum;

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
                        Console.WriteLine("Aperte ENTER para continuar");
                        Console.ReadLine();
                        continue;
                    }
                }  
            }   
        }
    }
}
