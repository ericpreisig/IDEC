class Produit
{
    private string _nom { get; set; }
    private double _prix { get; set; }
    private int _quantiteStock { get; set; }

    public Produit(string nom, double prix, int quantiteStock)
    {
        _nom = nom;
        _prix = prix;
        _quantiteStock = quantiteStock;
    }

    public void AfficherInfo()
    {
        Console.WriteLine($"Nom : {_nom}, Prix : {_prix} CHF, Stock : {_quantiteStock}");
    }
}
