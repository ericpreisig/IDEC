class Electronique : Produit
{
    public int Garantie { get; set; }

    public Electronique(string nom, double prix, int quantiteStock, int garantie)
        : base(nom, prix, quantiteStock)
    {
        Garantie = garantie;
    }
}
