using System;
using System.Collections.Generic;

namespace Exercice2
{
    public class Gestion
    {
        private readonly Stock _stock;

        public Gestion()
        {
            _stock = new Stock();
        }

        public void Menu()
        {
            Console.WriteLine("1 : Ajouter");
            Console.WriteLine("2 : Modifier");
            Console.WriteLine("3 : Supprimer");
            Console.WriteLine("4 : Recherche par référence");
            Console.WriteLine("5 : Recherche par type");
            Console.WriteLine("6 : Recherche par nom");
            Console.WriteLine("7 : Recherche par prix");
            Console.WriteLine("8 : Tout afficher");

            int option = GetOption(8);
            Console.Clear();

            switch (option)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    Update();
                    break;
                case 3:
                    Delete();
                    break;
                case 4:
                    RechecheParReference();
                    break;
                case 5:
                    RechecheParType();
                    break;
                case 6:
                    RechecheParNom();
                    break;
                case 7:
                    RechecheParPrix();
                    break;
                case 8:
                    DisplayAll();
                    break;
            }

            Console.ReadLine();
            Console.Clear();
            Menu();
        }

        private void DisplayAll()
        {
            Display(_stock.GetAll());
        }

        private void RechecheParNom()
        {
            Console.Write("Nom : ");
            string nom = Console.ReadLine();
            Display(_stock.Recherche(nom));
        }

        private void RechecheParReference()
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

        private void RechecheParPrix()
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

        private void RechecheParType()
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

        private void Display(List<Produit> produits)
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

        private void Display(Produit produit)
        {
            if (produit == null)
            {
                Console.WriteLine("Aucun produit valide à afficher");
                return;
            }
            Console.WriteLine($"Type : {GetTypeName(produit)}");
            Console.WriteLine($"Reference : {produit.NumeroReference}");
            Console.WriteLine($"Nom : {produit.Nom}");
            Console.WriteLine($"Prix : {produit.Prix}");
        }

        private string GetTypeName(Produit produit)
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

        private int GetOption(int maxOption)
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

        private void Delete()
        {
            Console.WriteLine("Suprimer un produit :");

            Console.Write("Numéro de référence :");

            if (int.TryParse(Console.ReadLine(), out int numero))
            {             
                if (_stock.Delete(numero))
                {
                    Console.Write("Produit Supprimer !");                 
                }
                else
                {
                    Console.WriteLine("Le produit n'existe pas !");
                    Cancel();
                }
            }
            else
            {
                Console.WriteLine("Le format du numéro est invalide");
                Cancel();
            }
        }

        private void Update()
        {
            Console.WriteLine("Modifier un produit :");

            Console.Write("Numéro de référence :");

            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                Produit produit = _stock.Recherche(numero);

                if (_stock.Recherche(numero) != null)
                {
                    if(ChangeNom(produit) && ChangePrix(produit))
                    {
                        Console.WriteLine("Produit mis à jour !");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Le produit n'existe pas !");
                }
            }
            else
            {
                Console.WriteLine("Le format du numéro est invalide");
            }

            Cancel();
        }

        private void Add()
        {
            Produit produit = null;

            Console.WriteLine("1 : T-Shirt");
            Console.WriteLine("2 : Pantalon");
            Console.WriteLine("3 : Chapeau");
            Console.WriteLine("4 : Chaussette");

            int option = GetOption(4);
            Console.Clear();

            switch (option)
            {
                case 1:
                    produit = new Tshirt();
                    break;
                case 2:
                    produit = new Pantalon();
                    break;
                case 3:
                    produit = new Chapeau();
                    break;
                case 4:
                    produit = new Chaussette();
                    break;
            }

            Console.WriteLine("Ajout d'un produit :");

            if(ChangeNumero(produit) && ChangeNom(produit) && ChangePrix(produit))
            {
                _stock.Add(produit);
                Console.WriteLine("Produit ajouté");
            }
            else
            {
                Cancel();
            }
        }

        private bool ChangeNumero(Produit produit)
        {
            Console.Write("N° Référence : ");

            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (_stock.Recherche(numero) == null)
                {
                    produit.NumeroReference = numero;
                    return true;
                }
                else
                {
                    Console.WriteLine("Le numéro est déjà utilisé !");
                }
            }
            else
            {
                Console.WriteLine("Le format du numéro est invalide");
            }
            return false;
        }

        private bool ChangePrix(Produit produit)
        {
            Console.Write("Prix : ");

            if (double.TryParse(Console.ReadLine(), out double prix))
            {
                produit.Prix = prix;
                return true;
            }
            else
            {
                Console.WriteLine("Le format du numéro est invalide");
                return false;
            }
        }

        private bool ChangeNom(Produit produit)
        {
            Console.Write("Nom : ");

            string nom = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(nom))
            {
                produit.Nom = nom;
                return true;
            }
            else
            {
                Console.WriteLine("Nom invalide !");
                return false;
            }
        }

        private void Cancel()
        {
            Console.WriteLine("Annulation...");
        }
    }
}
