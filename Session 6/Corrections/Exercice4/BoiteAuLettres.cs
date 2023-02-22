using System;
using System.Collections.Generic;

namespace Exercice1
{
    public class BoiteAuLettres
    {
        private readonly List<Courrier> _courriers = new List<Courrier>();

        public void Ajouter(Courrier courrier)
        {
            _courriers.Add(courrier);
        }

        public double Affranchir()
        {
            double total = 0;
            foreach (var courrier in _courriers)
            {
                if (courrier.IsValid())
                {
                    total += courrier.PrixAffranchissement();
                }
            }

            return total;
        }

        public int CourrierInvalide()
        {
            int total = 0;
            foreach (var courrier in _courriers)
            {
                if (!courrier.IsValid())
                {
                    total++;
                }
            }

            return total;
        }     

        public void AfficherToutLesCourriers()
        {
            foreach (var courrier in _courriers)
            {
                courrier.Afficher();
                Console.WriteLine();
            }
        }
    }
}
