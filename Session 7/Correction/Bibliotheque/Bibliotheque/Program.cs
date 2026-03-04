public class Program
{
    private static readonly List<Auteur> _auteurs = [];
    private static readonly List<string> _categories =
    [
        "Roman",
        "Science",
        "Histoire",
        "Informatique",
        "Jeunesse"
    ];

    private static readonly Bibliotheque _bibliotheque = new();

    private static void Main()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1 - Ajouter un auteur");
            Console.WriteLine("2 - Ajouter un livre");
            Console.WriteLine("3 - Afficher le catalogue");
            Console.WriteLine("0 - Quitter");

            var choix = Console.ReadLine();

            if (choix == "1")
                AjouterAuteur();

            else if (choix == "2")
                AjouterLivre();

            else if (choix == "3")
                _bibliotheque.AfficherCatalogue();

            else if (choix == "0")
                break;
        }
    }

    private static void AjouterAuteur()
    {
        Console.WriteLine("Prénom de l'auteur :");
        string prenom = Console.ReadLine();

        Console.WriteLine("Nom de l'auteur :");
        string nom = Console.ReadLine();

        _auteurs.Add(new Auteur(nom, prenom));

        Console.WriteLine("Auteur ajouté.");
    }

    private static void AjouterLivre()
    {
        if (_auteurs.Count == 0)
        {
            Console.WriteLine("Aucun auteur disponible. Ajoutez d'abord un auteur.");
            return;
        }

        Console.WriteLine("Titre du livre :");
        string titre = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Choisissez un auteur :");

        for (int i = 0; i < _auteurs.Count; i++)
            Console.WriteLine($"{i + 1} - {_auteurs[i]}");

        int choixAuteur = int.Parse(Console.ReadLine()) - 1;
        var auteur = _auteurs[choixAuteur];

        Console.WriteLine();
        Console.WriteLine("Choisissez une catégorie :");

        for (int i = 0; i < _categories.Count; i++)
            Console.WriteLine($"{i + 1} - {_categories[i]}");

        int choixCategorie = int.Parse(Console.ReadLine()) - 1;
        string categorie = _categories[choixCategorie];

        var livre = new Livre(titre, auteur, categorie);

        _bibliotheque.AjouterLivre(livre);
    }
}
