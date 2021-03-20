using System;

namespace Aula_de_PC1__F_C
{
    class Program
    {
        static void Main(string[] args)
        {
            double Fahrenheit;
            double Celsius = 32;
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("========================================================");
            Console.WriteLine("Você sabia que o °C não é a ùnica medida de temperatura?");
            Console.WriteLine("========================================================");
            Console.ResetColor();
            Console.WriteLine("\nExiste o grau Fahrenheit.\n\nAgora digite um valor para a temperatura em Fahrenheit:");
            Fahrenheit = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine($"{Fahrenheit}°F equivale á exatamente: {Fahrenheit - Celsius / 1.8 }°C");
            Console.ResetColor();
            Console.WriteLine("Aperte qualquer botão para sair...");
            Console.ReadKey();
            Console.Clear();


        }
    }
}
