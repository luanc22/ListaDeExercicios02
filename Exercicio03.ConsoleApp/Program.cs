using System;

namespace Exercicio03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // linhas 9 a 13 = inicio e condicao do while para rodar o programa ate que o usuario deseje parar.

            bool fecharApp = false;

            while (fecharApp == false)
            {
                // linhas 17 a 41 = input de dados, conversao de tipos de dados para utilizacao e declaracao de variaveis utilizadas.

                Console.WriteLine("===== Calcular IMC =====");
                Console.WriteLine("");
                Console.WriteLine("Programa para calcular o IMC.");
                Console.WriteLine("");

                Console.Write("Digite seu nome: ");
                string inputNome = Console.ReadLine();
                Console.Write("Digite sua altura em metros separado por virgula (ex: 1,80): ");
                string inputAlt = Console.ReadLine();
                Console.Write("Digite seu peso em kilos: ");
                string inputPes = Console.ReadLine();

                double altNum = double.Parse(inputAlt);
                double pesNum = double.Parse(inputPes);

                double abxPes = 18.4;
                double pesNorMin = 18.5;
                double pesNorMax = 25;
                double pesAciMin = 25.1;
                double pesAciMax = 30;
                double pesObs = 30.1;

                double imcResult = pesNum / (altNum * altNum);

                Console.WriteLine("");

                // linhas 45 a 78 = condicoes para cada situacao + output do resultado.

                if (imcResult <= abxPes)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(inputNome + ", cuidado, voce se encontra com o IMC de condicao \"abaixo do peso\".");
                    Console.ResetColor();
                    Console.WriteLine("Seu resultado IMC foi: {0}.", Math.Round(imcResult,1));
                }
                else if (imcResult >= pesNorMin && imcResult <= pesNorMax)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(inputNome + ", parabens, voce se encontra com o IMC de condicao \"peso normal\".");
                    Console.ResetColor();
                    Console.WriteLine("Seu resultado IMC foi: {0}.", Math.Round(imcResult, 1));
                }
                if (imcResult >= pesAciMin && imcResult <= pesAciMax)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(inputNome + ", cuidado, voce se encontra com o IMC de condicao \"acima do peso\".");
                    Console.ResetColor();
                    Console.WriteLine("Seu resultado IMC foi: {0}.", Math.Round(imcResult, 1));
                }
                if (imcResult >= pesObs)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(inputNome + ", cuidado, voce se encontra com o IMC de condicao \"obeso\".");
                    Console.ResetColor();
                    Console.WriteLine("Seu resultado IMC foi: {0}.", Math.Round(imcResult, 1));
                }

                Console.WriteLine("");
                Console.WriteLine("Lembre-se sempre de ter uma dieta saudavel, praticar exercicios regularmente e beber agua.");
                Console.WriteLine("");
                Console.WriteLine("Aperte ENTER para prosseguir.");
                Console.ReadLine();

                // linhas 82 a 128 = inicio e condicao do while de menu de escolha do usuario para sair da aplicao ou permanecer rodando a mesma apos o uso.

                bool opcaoValida = false;

                while (opcaoValida == false)
                {
                    Console.WriteLine("Caso deseje verificar a tabela de IMC, digite 2 e aperte ENTER.");
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
                    else if (fecharBotao == "2")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("========= Tabela de IMC =========");
                        Console.WriteLine("Abaixo de 18,5 | Abaixo do Peso.");
                        Console.WriteLine("Entre 18,5 e 25 | Peso Normal.");
                        Console.WriteLine("Entre 25 e 30  |  Acima do Peso.");
                        Console.WriteLine("Acima de 30 | Obeso.");
                        Console.WriteLine("==================================");

                        Console.WriteLine("");
                        Console.WriteLine("Aperte ENTER para prosseguir.");
                        Console.ReadLine();
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
