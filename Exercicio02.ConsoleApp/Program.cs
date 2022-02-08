using System;

namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool fecharApp = false;

            while (fecharApp == false)
            {
                Console.WriteLine("===== Ordem Decrescente =====");
                Console.WriteLine("");
                Console.WriteLine("Programa para calcular se a soma de A + B resulta menor que C.");
                Console.WriteLine("");

                Console.Write("Insira o primeiro numero: ");
                string inputNumOne = Console.ReadLine();
                Console.Write("Insira o segundo numero: ");
                string inputNumTwo = Console.ReadLine();
                Console.Write("Insira o terceiro numero: ");
                string inputNumThree = Console.ReadLine();

                int numOne = int.Parse(inputNumOne);
                int numTwo = int.Parse(inputNumTwo);
                int numThree = int.Parse(inputNumThree);

                Console.WriteLine("");

                if (numOne == numTwo || numTwo == numThree || numOne == numThree)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Numeros iguais identificados, por favor, digite tres numeros diferentes.");
                    Console.ResetColor();
                }
                else if (numOne > numTwo && numTwo > numThree)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("A ordem decrescente fica: {0} > {1} > {2}.", numOne, numTwo, numThree);
                    Console.ResetColor();
                }
                else if (numOne > numTwo && numOne > numThree && numThree > numTwo)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("A ordem decrescente fica: {0} > {1} > {2}.", numOne, numThree, numTwo);
                    Console.ResetColor();
                }
                else if (numTwo > numOne && numOne > numThree)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("A ordem decrescente fica: {0} > {1} > {2}.", numTwo, numOne, numThree);
                    Console.ResetColor();
                }
                else if (numTwo > numOne && numTwo > numThree && numThree > numOne)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("A ordem decrescente fica: {0} > {1} > {2}.", numTwo, numThree, numOne);
                    Console.ResetColor();
                }
                else if (numThree > numOne && numOne > numTwo)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("A ordem decrescente fica: {0} > {1} > {2}.", numThree, numOne, numTwo);
                    Console.ResetColor();
                }
                else if (numThree > numOne && numTwo > numOne)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("A ordem decrescente fica: {0} > {1} > {2}.", numThree, numTwo, numOne);
                    Console.ResetColor();
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
                        Console.ForegroundColor = ConsoleColor.Red;
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
