namespace JeuDeCartes
{
    public class Carte
    {
        private int _couleur;
        private int _valeur;

        public Carte(int couleur, int valeur)
        {
            _couleur = couleur;
            _valeur = valeur;
        }

        public int GetValeur()
        {
            return _valeur;
        }

        public string GetText()
        {
            return $"Le {GetName()} de {GetCouleur()}";
        }

        private string GetCouleur()
        {
            switch (_couleur)
            {
                case 0:
                    return "Coeur";
                case 1:
                    return "Carreau";
                case 2:
                    return "Pique";
                case 3:
                    return "Trefle";
                default:
                    return "";
            }
        }

        private string GetName()
        {
            switch (_valeur)
            {
                case 10:
                    return "Valet";
                case 11:
                    return "Dame";
                case 12:
                    return "Roi";
                case 0:
                    return "As";
                default:
                    return (_valeur + 1).ToString();
            }
        }
    }
}
