namespace Exercice2
{
    public class Rectangle
    {
        private readonly double _hauteur;
        private readonly double _largeur;

        public Rectangle(double hauteur, double largeur)
        {
            _hauteur = hauteur;
            _largeur = largeur;
        }

        public double GetSurface() 
        { 
            return _hauteur * _largeur;
        }
    }
}