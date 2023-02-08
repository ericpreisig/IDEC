namespace Exercice3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CompteBancaire compteDupont = new CompteBancaire("Jean Dupont");
            CompteBancaire compteSmith = new CompteBancaire("John Smith");

            compteDupont.Depot(100);
            compteSmith.Depot(50);

            compteDupont.Retrait(80);
            compteSmith.Retrait(80);

            compteDupont.AfficherMontant();
            compteSmith.AfficherMontant();
        }
    }
}