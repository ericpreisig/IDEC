namespace JeuDeCartes
{
    public class Deck
    {
        private List<Carte> _cartes = new List<Carte>();
        public void AjouterCarte(Carte carte)
        {
            _cartes.Add(carte);
        }

        public void AjouterCartes(List<Carte> cartes)
        {
            _cartes.AddRange(cartes);
        }

        public int NombreDeCartes()
        {
            return _cartes.Count;
        }

        public void Melanger()
        {
            var random = new Random();

            for(var i = 0; i < _cartes.Count; i++)
            {
                int newIndex = random.Next(0, _cartes.Count);
                var oldCarte = _cartes[i];
                _cartes[i] = _cartes[newIndex];
                _cartes[newIndex] = oldCarte;
            }
        }

        public Carte Piocher()
        {
            // Cas particulier pour quand le joueur n'as plus de carte durant une bataille
            if(_cartes.Count == 0)
            {
                return new Carte(0, 0);
            }

            var carte = _cartes[0];
            _cartes.RemoveAt(0);
            return carte;
        }
    }
}
