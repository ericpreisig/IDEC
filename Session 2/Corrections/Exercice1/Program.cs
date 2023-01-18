Console.Write("Veuillez entrer le premier nombre : ");
int nombre1 = int.Parse(Console.ReadLine());

Console.Write("Veuillez entrer le deuxième nombre : ");
int nombre2 = int.Parse(Console.ReadLine());

Console.Write("Veuillez entrer le troisième nombre : ");
int nombre3 = int.Parse(Console.ReadLine());

int resultat;
if (nombre1 > nombre2 && nombre1 > nombre3)
{
    resultat = nombre1;
}
else if (nombre2 > nombre1 && nombre2 > nombre3)
{
    resultat = nombre2;
}
else if (nombre3 > nombre1 && nombre3 > nombre2)
{
    resultat = nombre3;
}
else
{
    resultat = nombre1;
}

Console.WriteLine("Le chiffre le plus grand est : " + resultat);
Console.ReadLine();
