namespace Personne
{
    public class Personne
    {
        private string _prenom;
        private int _age;
        public Personne(string prenom, int age)
        {
            _prenom = prenom;
            _age = age;
        }

        public void SePresenter()
        {
            Console.WriteLine($"Bonjour je m'appelle {_prenom} et j'ai {_age} ans");
        }
    }
}
