using MyLibrary;

namespace MainProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Introdueix la base del triangle:");
                int baseTriangle = int.Parse(Console.ReadLine());

                Console.WriteLine("Introdueix l'altura del triangle:");
                int heightTriangle = int.Parse(Console.ReadLine());

                int resultado = numerador / denominador;
                Console.WriteLine($"El resultado de la división es: {resultado}");
            }
            catch
            {
                // Si ocurre cualquier excepción, mostramos un mensaje general.
                Console.WriteLine("Hubo un error. Intenta nuevamente.");
            }
        }
    }
}
