public class Livre
{
    public string Titre { get; }
    public Auteur Auteur { get; }
    public string Categorie { get; }

    public Livre(string titre, Auteur auteur, string categorie)
    {
        Titre = titre;
        Auteur = auteur;
        Categorie = categorie;
    }

    public override string ToString()
    {
        return $"{Titre} — {Auteur} ({Categorie})";
    }
}
