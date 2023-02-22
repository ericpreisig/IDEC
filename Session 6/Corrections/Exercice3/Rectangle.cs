using System.Xml.Linq;

namespace Exercice3
{
    public class Rectangle : Shape
    {
        private int _x;
        private int _y;

        public Rectangle(int x, int y)
        {
            Name = "Rectangle";
            _x = x;
            _y = y;
        }

        public override double CalculateAera()
        {
            return _x * _y;
        }
    }
}
