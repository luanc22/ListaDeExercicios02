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
            } 
        }
    }
}
