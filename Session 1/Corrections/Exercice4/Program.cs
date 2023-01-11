// Entrée de données
Console.WriteLine("Combien avez-vous reçu d'argent (Frs):) ");
int budget = int.Parse(Console.ReadLine());

// Calcul du budget livres & fournitures
int budgetLivres = budget * 3 / 4;
int resteBudget = budget - budgetLivres;

// Calcul du budget pour les trois autres rubriques
int autre = resteBudget / 3;

// Calcul du nombre de cafés
int nbcafes = autre / 2;

// Calcul du nombre de numéros du Flash
int nbFlash = autre / 4;

// Calcul du nombre de billets de TSOL
int nbBillets = autre / 3;

// Calcul de l'argent restant
int reste = autre % 2 + autre % 4 + autre % 3 + resteBudget % 3;

// Affichage des résultats
Console.WriteLine("Livres et Fournitures: " + budgetLivres + " Frs.");
Console.WriteLine("Vous pouvez ensuite acheter:");
Console.WriteLine(" " + nbcafes + " cafés");
Console.WriteLine(" " + nbFlash + " numéros du Flash");
Console.WriteLine(" " + nbBillets + " billets de métro");
Console.WriteLine("et il vous restera " + reste + " Frs pour les roses rouges.");

Console.ReadLine();