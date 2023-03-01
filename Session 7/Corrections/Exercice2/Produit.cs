namespace Exercice2
{
    public abstract class Produit
    {
        public int NumeroReference { get; set; }
        public double Prix { get; set; }
        public string Nom { get; set; }
        public bool IsVendu { get; set; }
    }
}
