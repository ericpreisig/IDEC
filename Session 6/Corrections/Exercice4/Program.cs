using System;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            BoiteAuLettres boiteAuLettres = new BoiteAuLettres();

            boiteAuLettres.Ajouter(new Lettre()
            {
                Poids = 200,
                ModeExpedition = ModeExpedition.Express,
                Adresse = "Chemin des Acacias 28, 1009 Pully",
                Format = Format.A3
            });

            boiteAuLettres.Ajouter(new Publicite()
            {
                Poids = 1000,
                ModeExpedition = ModeExpedition.Normal,
                Adresse = "Chemin des Vallheureux 10, 1008 Prilly",
            });

            boiteAuLettres.Ajouter(new Coli()
            {
                Poids = 200,
                ModeExpedition = ModeExpedition.Express,
                Adresse = "Chemin des Acacias 28, 1009 Pully",
                Volume = 70
            });

            Console.WriteLine($"Le montant total d'affranchissement est de {boiteAuLettres.Affranchir()}CHF");

            boiteAuLettres.AfficherToutLesCourriers(); 

            Console.WriteLine($"La boite contient {boiteAuLettres.CourrierInvalide()} courriers invalides");

            Console.ReadLine();
        }
    }
}
