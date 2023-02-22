using System;

namespace Exercice3
{
    public class Circle : Shape
    {
        private int _r;

        public Circle(int r)
        {
            Name = "Cercle";
            _r = r;
        }

        public override double CalculateAera()
        {
            return Math.PI * _r * _r;
        }
    }
}
