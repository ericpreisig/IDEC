namespace Exercice1
{
    public class Employe : Personne
    {
        private double _salaire;

        public Employe(string nom, string prenom, int age, double salaire) : base(nom, prenom, age)
        {
            _salaire = salaire;
        }
    }
}
