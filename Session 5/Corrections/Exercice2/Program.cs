using System.Collections.Generic;

namespace Exercice2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(10, 5);
            double surfaceRectangle1 = rectangle1.GetSurface();

            Console.WriteLine($"La surface de ce rectangle est de {surfaceRectangle1}");
        }
    }
}