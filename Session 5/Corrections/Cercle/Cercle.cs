namespace Cercle
{
    public class Cercle
    {
        private readonly double _rayon;

        public Cercle(double rayon)
        {
            _rayon = rayon;
        }

        public double GetSurface()
        {
            return Math.PI * _rayon * _rayon;
        }
        public double GetPerimetre()
        {
            return 2 * Math.PI * _rayon;
        }
    }
}