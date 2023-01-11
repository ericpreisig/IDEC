const int BASE = 4;     // nombre de personnes pour la recette de base

// Pour faire une fondue fribourgeoise pour 4 personnes il faut : 

double fromage = 800;   // 800gr de Vacherin fribourgeois
double eau = 2;         // 2dl d'eau
double ail = 2;         // 2 gousses d'ail
double pain = 400;      // 400 gr de pain

/* On supposera pour cet exercice que l'utilisateur ne saisit que des
 * valeurs strictement positives, mais nous pourrons faire mieux dès
 * la semaine prochaine
 */
Console.WriteLine("Entrez le nombre de personne(s) conviée(s) à la fondue : ");

int nbConvives = int.Parse(Console.ReadLine());

// Mise à jour des quantités en fonction du nombre de convives :
double ratio = nbConvives;  // .. Notez le 'double' indispensable
                            // pour éviter la division entière
ratio /= BASE;
fromage *= ratio;
eau *= ratio;
ail *= ratio;
pain *= ratio;

Console.WriteLine();
Console.WriteLine("Pour faire une fondue fribourgeoise pour " + nbConvives + " personne(s), ");
Console.WriteLine("il vous faut : ");
Console.WriteLine(" - " + fromage + " gr de Vacherin fribourgeois");
Console.WriteLine(" - " + eau + " dl d'eau");
Console.WriteLine(" - " + ail + " gousse(s) d'ail");
Console.WriteLine(" - " + pain + " gr de pain");
Console.WriteLine(" - du poivre à volonté");

Console.ReadLine();
