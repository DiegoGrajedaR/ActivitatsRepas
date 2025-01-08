using MyLibrary;

namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueix la temperatura en graus Celsius:");

            if (double.TryParse(Console.ReadLine(), out double celsius))
            {
                double fahrenheit = MyMath.CelsiusToFahrenheit(celsius);

                Console.WriteLine($"{celsius} graus Celsius equival a {fahrenheit} graus Fahrenheit.");
            }
            else
            {
                Console.WriteLine("Nombre no vàlid")
            }
        }
    }
}
