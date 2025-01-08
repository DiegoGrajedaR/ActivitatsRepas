using System;
using MyLibrary;

namespace MainProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introdueix el nombre de segons:");
            int totalSeconds = int.Parse(Console.ReadLine());
           
            string result = MyMath.SecondsToTime(totalSeconds);
            Console.WriteLine($"El temps total és de: {result}");

        }
    }
}
