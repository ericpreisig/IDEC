using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Services;

namespace Exercice2
{
    public class PortailPrive : Portail
    {
        public override void Menu()
        {
            DisplayTotalSales();
            Console.WriteLine();

            Console.WriteLine("1 : Ajouter");
            Console.WriteLine("2 : Modifier");
            Console.WriteLine("3 : Supprimer");
            Console.WriteLine("4 : Recherche par référence");
            Console.WriteLine("5 : Recherche par type");
            Console.WriteLine("6 : Recherche par nom");
            Console.WriteLine("7 : Recherche par prix");
            Console.WriteLine("8 : Tout afficher");
            Console.WriteLine("9 : Aller dans le portail public");

            int option = GetOption(9);
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
                case 9:
                    new PortailPublic().Menu();
                    break;
            }

            Console.ReadLine();
            Console.Clear();
            Menu();
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

        public bool CheckPassword(string userPassword)
        {
            string password = File.ReadAllText("password.txt");

            return userPassword == password;
        }

        private void DisplayTotalSales()
        {
            double totalSumSales = _stock.GetAll().Where(p => p.IsVendu).Sum(p => p.Prix);

            Console.WriteLine($"Le total des ventes est de {totalSumSales} CHF");
        }
    }
}
