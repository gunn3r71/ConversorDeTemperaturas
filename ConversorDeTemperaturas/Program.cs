using System;
using System.Globalization;

namespace ConversorDeTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("################################ Bem-vindo(a) ao conversor de temperatura ################################");
            Console.Write("Digite a temperatura para converter: ");
            c = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            f = c * 9/5 + 32;
            k = c + 273.15;
            Console.WriteLine("Conversão em fahrenheit\t|\tConversão em Kelvin");
            Console.WriteLine($"{f.ToString("F2",CultureInfo.InvariantCulture)}\t\t\t|\t\t\t{k.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}
