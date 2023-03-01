using System;
using System.Collections.Generic;

namespace Exercice2
{
    public abstract class Portail
    {
        protected readonly static Stock _stock = new Stock();

        public abstract void Menu();

        protected void DisplayAll()
        {
            Display(_stock.GetAll());
        }

        protected void RechecheParNom()
        {
            Console.Write("Nom : ");
            string nom = Console.ReadLine();
            Display(_stock.Recherche(nom));
        }

        protected void RechecheParReference()
        {
            Console.Write("Reference : ");

            if (int.TryParse(Console.ReadLine(), out int reference))
            {
                Display(_stock.Recherche(reference));
            }
            else
            {
                Console.WriteLine("Numéro invalide");
            }
        }

        protected void RechecheParPrix()
        {
            Console.Write("Prix min : ");

            if(double.TryParse(Console.ReadLine(), out double prixMin))
            {
                Console.Write("Prix max : ");

                if (double.TryParse(Console.ReadLine(), out double prixMax))
                {
                    Display(_stock.Recherche(prixMin, prixMax));
                }
                else
                {
                    Console.WriteLine("Prix invalide");
                }
            }
            else
            {
                Console.WriteLine("Prix invalide");
            }
        }

        protected void RechecheParType()
        {
            Console.WriteLine("1 : T-Shirt");
            Console.WriteLine("2 : Pantalon");
            Console.WriteLine("3 : Chapeau");
            Console.WriteLine("4 : Chaussette");

            int option = GetOption(4);

            Console.Clear();

            switch (option)
            {
                case 1:
                    Display(_stock.Recherche(typeof(Tshirt)));
                    break;
                case 2:
                    Display(_stock.Recherche(typeof(Pantalon)));
                    break;
                case 3:
                    Display(_stock.Recherche(typeof(Chapeau)));
                    break;
                case 4:
                    Display(_stock.Recherche(typeof(Chaussette)));
                    break;
            }
        }

        protected void Display(List<Produit> produits)
        {
            if (produits.Count == 0)
            {
                Console.WriteLine("Rien à afficher");
                return;
            }

            foreach(Produit produit in produits)
            {
                Display(produit);
            }
        }

        protected void Display(Produit produit)
        {
            Console.WriteLine($"Type : {GetTypeName(produit)}");
            Console.WriteLine($"Reference : {produit.NumeroReference}");
            Console.WriteLine($"Nom : {produit.Nom}");
            Console.WriteLine($"Prix : {produit.Prix}");
        }

        protected string GetTypeName(Produit produit)
        {
            if(produit is Tshirt)
            {
                return "T-Shirt";
            }
            if (produit is Pantalon)
            {
                return "Pantalon";
            }
            if (produit is Chapeau)
            {
                return "Chapeau";
            }
            if (produit is Chaussette)
            {
                return "Chaussette";
            }

            return "";
        }

        protected int GetOption(int maxOption)
        {
            if(int.TryParse(Console.ReadLine(), out int option) && option <= maxOption)
            {
                return option;
            }
            else
            {
                Console.WriteLine("Option invalide !");
                return GetOption(maxOption);
            }
        }

        protected void Cancel()
        {
            Console.WriteLine("Annulation...");
        }
    }
}
