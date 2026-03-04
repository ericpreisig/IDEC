public class Auteur
{
    public string Nom { get; }
    public string Prenom { get; }

    public Auteur(string nom, string prenom)
    {
        Nom = nom;
        Prenom = prenom;
    }

    public override string ToString()
    {
        return $"{Prenom} {Nom}";
    }
}
