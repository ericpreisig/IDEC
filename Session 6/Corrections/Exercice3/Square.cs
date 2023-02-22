namespace Exercice3
{
    public class Square : Rectangle
    {
        private int _x;

        public Square(int x) : base(x, x)
        {
            Name = "Carré";
            _x = x;
        }
    }
}
