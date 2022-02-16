using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Calculadora dllack");

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisao");

            Console.WriteLine("------------");
            Console.Write("Digite uma opção: ");
            short opcao = short.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Soma();
            }

            if (opcao == 2)
            {
                Subtracao();
            }

            if (opcao == 3)
            {
                Multiplicacao();
            }

            if (opcao == 4)
            {
                Divisao();
            }

        }

        static void Soma()
        {
            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");

            Console.WriteLine("");

            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            double resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");

            Console.WriteLine("");

            Console.ReadKey();
        }

        static void Multiplicacao()
        {
            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");

            Console.WriteLine("");

            Console.ReadKey();
        }

        static void Divisao()
        {
            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");

            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
