using System;

namespace Exercice3
{
    public abstract class Shape
    {
        public string Color { get; set; }
        public string Name { get; protected set; }
        public abstract double CalculateAera();

        public void ShowColor()
        {
            if (!string.IsNullOrWhiteSpace(Color))
            {
                Console.WriteLine($"La couleur est : {Color}");
            }
            else
            {
                Console.WriteLine("Couleur non définie ");
            }
        }
    }
}
