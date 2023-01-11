// on fera mieux plus tard !
int ANNEE_COURANTE = 2023;

Console.WriteLine("Quel est votre age ?");

int age = int.Parse(Console.ReadLine());

double annee = ANNEE_COURANTE - age;

Console.WriteLine("Votre annee de naissance est : " + annee);

Console.ReadLine();