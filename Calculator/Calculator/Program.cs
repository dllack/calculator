using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();
        }

        static void Soma()
        {
            Console.WriteLine("Primeiro valor:");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");

            Console.ReadKey();
        }
    }
}
