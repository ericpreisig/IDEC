namespace Exercice3
{
    public class Triangle : Shape
    {
        private int _x;
        private int _y;

        public Triangle(int x, int y)
        {
            Name = "Triangle";
            _x = x;
            _y = y;
        }

        public override double CalculateAera()
        {
            return _x * _y / 2;
        }
    }
}
