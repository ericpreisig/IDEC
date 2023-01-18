int resultat = int.MinValue;

for (int i = 0; i < 3; i++)
{
    Console.Write("Veuillez entrer le nombre n° " + (i + 1) + ": ");
    int nombre = int.Parse(Console.ReadLine());

    if (nombre > resultat)
    {
        resultat = nombre;
    }
}

Console.WriteLine("Le chiffre le plus grand est : " + resultat);
Console.ReadLine();