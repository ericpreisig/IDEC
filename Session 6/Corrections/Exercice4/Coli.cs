using System;

namespace Exercice1
{
    public class Coli : Courrier
    {
        public int Volume { get; set; }

        public override bool IsValid()
        {
            return base.IsValid() && Volume < 50;
        }

        public override double PrixAffranchissement()
        {
            double prix = 0.25 * Volume + Poids / 1000 * 1.0;
       
            if (ModeExpedition == ModeExpedition.Express)
            {
                return prix * 2;
            }
            else
            {
                return prix;
            }
        }
        public override void Afficher()
        {
            Afficher("Coli");
            Console.WriteLine($"Volume : {Volume} litres");
        }
    }
}
