namespace Exercice1
{
    public abstract class Courrier
    {
        public double Poids { get; set; }
        public ModeExpedition ModeExpedition { get; set; }
        public string Adresse { get; set; }

        public abstract double PrixAffranchissement();
        public abstract void Afficher();

        public virtual bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Adresse);
        }

        protected void Afficher(Courrier courrier, string nom)
        {
            Console.WriteLine(nom);

            if (!courrier.IsValid())
            {
                Console.WriteLine("(Courrier  invalide)");
            }

            Console.WriteLine($"Poids: {courrier.Poids} grammes");
            Console.Write($"Express:");

            if (courrier.ModeExpedition == ModeExpedition.Express)
            {
                Console.WriteLine("Oui");
            }
            else
            {
                Console.WriteLine("Non");
            }

            Console.WriteLine($"Destination: {courrier.Adresse}");
            Console.WriteLine($"Prix: {courrier.PrixAffranchissement()}CHF");
        }
    }
}
