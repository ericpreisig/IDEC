using Exercice1;

namespace Exercice4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Agence mi6 = new Agence("MI6");
            Agent james = new Agent("Bond", "James");
            Agent bill = new Agent("Tanner", "Bill");

            mi6.AjouterAgent(james);
            mi6.AjouterAgent(bill);

            Agence oss = new Agence("OSS");
            Agent hubert = new Agent("Bonisseur", "Hubert");

            oss.AjouterAgent(hubert);

            mi6.Identification();
            mi6.AgentsIntoduction();

            oss.Identification();
            oss.AgentsIntoduction();
        }
    }
}