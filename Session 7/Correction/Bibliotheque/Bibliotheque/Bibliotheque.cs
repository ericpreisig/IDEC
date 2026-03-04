public class Bibliotheque
{
    private readonly List<Livre> _livres = [];

    public void AjouterLivre(Livre livre)
    {
        bool existe = _livres.Any(l =>
            l.Titre == livre.Titre &&
            l.Auteur.Nom == livre.Auteur.Nom &&
            l.Auteur.Prenom == livre.Auteur.Prenom);

        if (existe)
        {
            Console.WriteLine("Ce livre existe déjà dans la bibliothèque.");
            return;
        }

        _livres.Add(livre);
        Console.WriteLine("Livre ajouté.");
    }

    public void AfficherCatalogue()
    {
        Console.WriteLine();
        Console.WriteLine("Catalogue :");
        Console.WriteLine();

        foreach (var livre in _livres)
            Console.WriteLine(livre);
    }
}
