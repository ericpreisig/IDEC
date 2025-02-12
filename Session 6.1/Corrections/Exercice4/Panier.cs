class Panier
{
    private List<Produit> _produits = new List<Produit>();

    public void AjouterProduit(Produit produit)
    {
        _produits.Add(produit);
    }

    public void AfficherContenu()
    {
        foreach (var produit in _produits)
        {
            produit.AfficherInfo();

            // CODE BONUS
            //if (produit is Livre livre)
            //{
            //    Console.WriteLine($"Auteur : {livre.Auteur}");
            //}
            //else if (produit is Vetement vetement)
            //{
            //    Console.WriteLine($"Taille : {vetement.Taille}");
            //}
            //else if (produit is Electronique electronique)
            //{
            //    Console.WriteLine($"Garantie : {electronique.Garantie} mois");
            //}

            Console.WriteLine();
        }
    }
}
