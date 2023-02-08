namespace Exercice1
{
    public class Agent
    {
        private readonly string _nom;
        private readonly string _prenom;

        public Agent(string nom, string prenom)
        {
            _nom = nom;
            _prenom = prenom;
        }

        public void Introduction()
        {
            Console.WriteLine($"Mon nom est {_nom}. {_prenom} {_nom}");
        }
    }
}