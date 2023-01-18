bool continuer = true;

do
{
    Console.WriteLine("Quelle couleur voulez-vous ?");
    Console.WriteLine("1 : Rouge");
    Console.WriteLine("2 : Vert");
    Console.WriteLine("3 : Bleu");
    Console.WriteLine("4 : Jaune");
    Console.WriteLine("5 : Blanc");
    Console.WriteLine("Quelle couleur voulez-vous ?");

    int resultat = int.Parse(Console.ReadLine());
    bool choixValide = true;

    switch (resultat)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.Red;
            break;
        case 2:
            Console.ForegroundColor = ConsoleColor.Green;
            break;
        case 3:
            Console.ForegroundColor = ConsoleColor.Blue;
            break;
        case 4:
            Console.ForegroundColor = ConsoleColor.Yellow;
            break;
        case 5:
            Console.ForegroundColor = ConsoleColor.White;

            break;
        default:
            choixValide = false;
            break;
    }

    if (choixValide == true)
    {
        Console.WriteLine("Ceci est un texte de couleur");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    else
    {
        Console.WriteLine("Cette option est impossible");
    }

    string choix = "";
    while (choix != "oui" && choix != "non")
    {
        Console.Write("Voulez-vous sélectionner une autre couleur (oui / non)");
        choix = Console.ReadLine();
    }

    if (choix == "non")
    {
        continuer = false;
    }
    else
    {
        Console.Clear();
    }

} while (continuer);
