string saisie;

Console.WriteLine("Entrez x: ");
saisie = Console.ReadLine();
int x = 0;
int.TryParse(saisie, out x);


Console.WriteLine("Entrez y: ");
saisie = Console.ReadLine();
int y = 0;
int.TryParse(saisie, out y);

Console.WriteLine("Avant permutation: ");
Console.WriteLine("x : " + x);
Console.WriteLine("y : " + y);

int tmp = x;
x = y;
y = tmp;

Console.WriteLine("Après permutation: ");
Console.WriteLine("x : " + x);
Console.WriteLine("y : " + y);

Console.ReadLine();
