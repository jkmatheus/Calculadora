using System;
using System.Globalization;

namespace Calculadora
{
    class Interface
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Calculadora ===");
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("+ Adição");
            string operacao = Console.ReadLine();

            if (operacao == "+")
            {
                Adicao adicao = new Adicao();
                adicao.Num1 = num1;
                adicao.Num2 = num2;
                Console.WriteLine($"Resultado: {adicao.Resultado}");
            }
            else
            {
                Console.WriteLine("Operação inválida.");
            }
        }
    }
}