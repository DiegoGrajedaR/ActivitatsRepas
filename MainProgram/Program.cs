using System;
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
                double baseTriangle = double.Parse(Console.ReadLine());

                Console.WriteLine("Introdueix l'altura del triangle:");
                double heightTriangle = double.Parse(Console.ReadLine());

                double resultat = MyMath.CalculateTriangleArea(baseTriangle, heightTriangle);
                Console.WriteLine($"L'area del triangle és de: {resultat}");
            }
            
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
