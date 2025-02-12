class Vetement : Produit
{
    public string Taille { get; set; }

    public Vetement(string nom, double prix, int quantiteStock, string taille)
        : base(nom, prix, quantiteStock)
    {
        Taille = taille;
    }
}
