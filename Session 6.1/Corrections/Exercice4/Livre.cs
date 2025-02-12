class Livre : Produit
{
    public string Auteur { get; set; }

    public Livre(string nom, double prix, int quantiteStock, string auteur)
        : base(nom, prix, quantiteStock)
    {
        Auteur = auteur;
    }
}
