namespace JeuDeCartes
{
    public class Joueur
    {
        private readonly string _pseudo;
        public Deck Deck { get; set; }

        public Joueur(string pseudo)
        {
            _pseudo = pseudo;
        }

        public string Name()
        {
            return _pseudo;
        }
    }
}
