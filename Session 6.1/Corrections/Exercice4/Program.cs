using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Livre livre1 = new Livre("C# pour les débutants", 29.90, 10, "John Doe");
        Vetement tshirt = new Vetement("T-shirt Noir", 15.50, 20, "M");
        Electronique smartphone = new Electronique("Smartphone X", 699.00, 5, 24);

        Panier panier = new Panier();
        panier.AjouterProduit(livre1);
        panier.AjouterProduit(tshirt);
        panier.AjouterProduit(smartphone);

        panier.AfficherContenu();
    }
}
