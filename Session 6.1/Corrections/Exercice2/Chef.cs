namespace Exercice1
{
    public class Chef : Employe
    {
        private string _service;

        public Chef(string nom, string prenom, int age, double salaire, string service) : base(nom, prenom, age, salaire)
        {
            _service = service;
        }
    }
}
