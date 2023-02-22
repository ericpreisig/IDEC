using System;

namespace Exercice1
{
    public class Lettre : Courrier
    {
        public Format Format { get; set; }

        public override double PrixAffranchissement()
        {
            double prixBase = GetPrixBase();

            double prix = prixBase + 1 * Poids / 1000;

            if(ModeExpedition == ModeExpedition.Express)
            {
                return prix * 2;
            }
            else
            {
                return prix;
            }
        }

        private double GetPrixBase()
        {
            switch (Format)
            {
                case Format.A4:
                    return 2.5;
                case Format.A3:
                    return 3.5;
                default:
                    return 0;
            }
        }

        public override void Afficher()
        {
            Afficher(this, "Lettre");
            Console.WriteLine($"Format : {Format}");
        }
    }
}
