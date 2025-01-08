using MyLibrary;

namespace MainProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introdueix la temperatura en graus Celsius:");

            if (double.TryParse(Console.ReadLine(), out double celsius))
            {
                double kelvin = MyMath.CelsiusToKelvin(celsius);

                Console.WriteLine($"{celsius} graus Celsius equival a {kelvin} graus Kelvin.");
            }
            else
            {
                Console.WriteLine("Nombre no vàlid")
            }
        }
    }
}
