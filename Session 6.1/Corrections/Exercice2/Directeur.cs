namespace Exercice1
{
    public class Directeur : Chef
    {
        private string _societe;

        public Directeur(string nom, string prenom, int age, double salaire, string service, string societe) : base(nom, prenom, age, salaire, service)
        {
            _societe = societe;
        }
    }
}
