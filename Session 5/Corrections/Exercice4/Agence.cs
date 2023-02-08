using Exercice1;

namespace Exercice4
{
    public class Agence
    {
        private readonly List<Agent> _agents = new List<Agent>();
        private readonly string _nom;

        public Agence(string nom)
        {
            _nom = nom;
        }

        public void AjouterAgent(Agent agent)
        {
            _agents.Add(agent);
        }

        public void Identification()
        {
            Console.WriteLine($"Chez {_nom} nous avons {_agents.Count} agents");
        }

        public void AgentsIntoduction()
        {
            foreach(Agent agent in _agents)
            {
                agent.Introduction();
            }
        }
    }
}