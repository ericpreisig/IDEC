using System;

namespace Exercice2
{
    public class PortailPublic : Portail
    {
        public override void Menu()
        {
            Console.WriteLine("1 : Recherche par référence");
            Console.WriteLine("2 : Recherche par type");
            Console.WriteLine("3 : Recherche par nom");
            Console.WriteLine("4 : Recherche par prix");
            Console.WriteLine("5 : Tout afficher");
            Console.WriteLine("6 : Acheter");
            Console.WriteLine("7 : Aller dans le portail privé");

            int option = GetOption(7);
            Console.Clear();

            switch (option)
            {
                case 1:
                    RechecheParReference();
                    break;
                case 2:
                    RechecheParType();
                    break;
                case 3:
                    RechecheParNom();
                    break;
                case 4:
                    RechecheParPrix();
                    break;
                case 5:
                    DisplayAll();
                    break;
                case 6:
                    Buy();
                    break;
                case 7:
                    GoToPrivatePorail();
                    break;
            }

            Console.ReadLine();
            Console.Clear();
            Menu();
        }

        private static void GoToPrivatePorail()
        {
            Console.Write("Enter le mot de passe : ");
            var portail = new PortailPrive();
            if (portail.CheckPassword(Console.ReadLine()))
            {
                Console.Clear();
                portail.Menu();
            }
            else
            {
                Console.WriteLine("Mot de passe incorecte");
            }
        }

        protected void Buy()
        {
            Console.Write("Reference : ");

            if (int.TryParse(Console.ReadLine(), out int reference))
            {
                Produit produit = _stock.Recherche(reference);
                if (produit.IsVendu)
                {
                    Console.WriteLine("Impossible d'acheter le produit car il est déjà vendu");
                }
                else
                {
                    Console.WriteLine("Le produit a été acheté");
                    produit.IsVendu = true;
                }    
            }
            else
            {
                Console.WriteLine("Numéro invalide");
            }
        }
    }
}
