string choix = "";
Random rng = new Random();
do
{
    Console.WriteLine("Deviner un nombre entre 1 et 100 !");

    int nombreAleatoire = rng.Next(1, 101);
    int nombreUtilisateur;

    do
    {
        nombreUtilisateur = int.Parse(Console.ReadLine());
        if (nombreUtilisateur > nombreAleatoire)
        {
            Console.WriteLine("Le chiffre est plus petit !");
        }
        else if (nombreUtilisateur < nombreAleatoire)
        {
            Console.WriteLine("Le chiffre est plus grand !");
        }
    } while (nombreUtilisateur != nombreAleatoire);

    Console.WriteLine("Victoire !!!");

    while (choix != "oui" && choix != "non")
    {
        Console.Write("Voulez-vous recommencer (oui / non)");
        choix = Console.ReadLine();
    }

} while (choix == "oui");