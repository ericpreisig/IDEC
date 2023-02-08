namespace Exercice3
{
    public class CompteBancaire
    {
        private decimal _montant = 0;
        private readonly string _beneficiaire;

        public CompteBancaire(string beneficiaire)
        {
            _beneficiaire = beneficiaire;
        }

        public void Depot(decimal montant)
        {
            _montant += montant;
        }

        public void Retrait(decimal montant)
        {
            if(_montant - montant >= 0)
            {
                _montant -= montant;
            }
            else
            {
                Console.WriteLine("Impossible de traiter cette demande : solde insufisant ");
            }
        }
        
        public void AfficherMontant()
        {
            Console.WriteLine($"Le montant disponible sur le compte de {_beneficiaire} est de {_montant}");
        }
    }
}