namespace Exercice1
{
    public class Publicite : Courrier
    {
        public override double PrixAffranchissement()
        {
            double prix = 5 * Poids / 1000;

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
            Afficher("Publicité");
        }
    }
}
