
Console.WriteLine("1 : Rouge");
Console.WriteLine("2 : Vert");
Console.WriteLine("3 : Bleu");
Console.WriteLine("4 : Jaune");
Console.WriteLine("5 : Blanc");
Console.WriteLine("Quelle couleur voulez-vous ?");

int resultat = int.Parse(Console.ReadLine());

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
        Console.WriteLine("Cette option est impossible");
        Console.ReadLine();
        return;
}

Console.WriteLine("Ceci est un texte de couleur");

Console.ReadLine();
