using System;
using System.Globalization;

namespace Calculadora
{
    class Program
    {
   
        public static void Main(string[] args)
        {




            Console.WriteLine("=== Calculadora ===");
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("+ Adição");
            string operacao = Console.ReadLine();

            if (operacao == "+")
            {
                double resultado = num1 + num2;
                Console.WriteLine($"Resultado: {resultado}");
            }
            else
            {
                Console.WriteLine("Operação inválida.");
            }


        }
    }
}