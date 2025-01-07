// on fera mieux plus tard !
int ANNEE_COURANTE = 2025;

Console.WriteLine("Quel est votre année de naissance ?");

int annee = int.Parse(Console.ReadLine());

double age = ANNEE_COURANTE - annee;

Console.WriteLine("Vous êtes dans l'année de vos " + age + " ans");

Console.ReadLine();