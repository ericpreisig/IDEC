namespace JeuDeCartes
{
    public class Jeu
    {
        private readonly Joueur _joueur1;
        private readonly Joueur _joueur2;

        public Jeu(Joueur joueur1, Joueur joueur2)
        {
            _joueur1 = joueur1;
            _joueur2 = joueur2;
        }

        public void Start()
        {
            DistributionDesCartes();

            while(_joueur1.Deck.NombreDeCartes() > 0 && _joueur2.Deck.NombreDeCartes() > 0)
            {
                Tour();
            }

            if(_joueur1.Deck.NombreDeCartes() == 0)
            {
                Console.WriteLine($"{_joueur2.Name()} a Gagné !");
            }
            else
            {
                Console.WriteLine($"{_joueur1.Name()} a Gagné !");
            }
        }

        public void DistributionDesCartes()
        {
            var deck = GenerationDesCarte();

            _joueur1.Deck = new Deck();
            _joueur2.Deck = new Deck();

            var nombreCartes = deck.NombreDeCartes();

            for (var i = 0; i < nombreCartes; i++)
            {
                if (i % 2 == 0)
                {
                    _joueur1.Deck.AjouterCarte(deck.Piocher());
                }
                else
                {
                    _joueur2.Deck.AjouterCarte(deck.Piocher());
                }
            }
        }

        public void Tour()
        {
            var carteJoueur1 = _joueur1.Deck.Piocher();
            var carteJoueur2 = _joueur2.Deck.Piocher();

            Console.WriteLine($"{_joueur1.Name()} à {carteJoueur1.GetText()}");
            Console.WriteLine($"{_joueur2.Name()} à {carteJoueur2.GetText()}");

            if (carteJoueur1.GetValeur() > carteJoueur2.GetValeur())
            {
                _joueur1.Deck.AjouterCarte(carteJoueur2);
                _joueur1.Deck.AjouterCarte(carteJoueur1);
                Console.WriteLine($"{_joueur1.Name()} gagne !");
            }
            else if (carteJoueur1.GetValeur() < carteJoueur2.GetValeur())
            {
                Console.WriteLine($"{_joueur2.Name()} gagne !");
                _joueur2.Deck.AjouterCarte(carteJoueur1);
                _joueur2.Deck.AjouterCarte(carteJoueur2);
            }
            else
            {
                // Bataille
                var cartes = new List<Carte>();
                cartes.Add(carteJoueur1);
                cartes.Add(carteJoueur2);

                do
                {
                    Console.WriteLine("Bataille !");
                    cartes.Add(_joueur1.Deck.Piocher());
                    cartes.Add(_joueur2.Deck.Piocher());

                    carteJoueur1 = _joueur1.Deck.Piocher();
                    carteJoueur2 = _joueur2.Deck.Piocher();

                    Console.WriteLine($"{_joueur1.Name()} à {carteJoueur1.GetText()}");
                    Console.WriteLine($"{_joueur2.Name()} à {carteJoueur2.GetText()}");

                    cartes.Add(carteJoueur1);
                    cartes.Add(carteJoueur2);

                    if (carteJoueur1.GetValeur() > carteJoueur2.GetValeur())
                    {
                        Console.WriteLine($"{_joueur1.Name()} gagne la bataille !");
                        _joueur1.Deck.AjouterCartes(cartes);
                    }
                    else if (carteJoueur1.GetValeur() < carteJoueur2.GetValeur())
                    {
                        Console.WriteLine($"{_joueur2.Name()} gagne la bataille !");
                        _joueur2.Deck.AjouterCartes(cartes);
                    }
                    else
                    {
                        Console.WriteLine("Encore une bataille !");
                    }

                } while (carteJoueur1.GetValeur() == carteJoueur2.GetValeur());

            }

            Console.ReadLine();
        }

        public Deck GenerationDesCarte()
        {
            var deck = new Deck();
            for(var i = 0; i < 4; i++)
            {
                for(var j = 0; j < 13; j++)
                {
                    deck.AjouterCarte(new Carte(i, j));
                }
            }

            deck.Melanger();

            return deck;
        }
    }
}
