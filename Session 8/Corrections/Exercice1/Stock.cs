using System;
using System.Collections.Generic;

namespace Exercice2
{
    public class Stock
    {
        private readonly List<Produit> _produits = new List<Produit>();

        public bool Add(Produit produit)
        {
            if (Recherche(produit.NumeroReference) != null)
            {
                return false;
            }

            _produits.Add(produit);
            return true;
        }

        public bool Delete(int numeroReference)
        {
            Produit produit = Recherche(numeroReference);
            if (produit == null)
            {
                return false;
            }
            
            _produits.Remove(produit);
            return true;
        }

        public Produit Recherche(int numeroReference)
        {
            foreach (Produit produit in _produits)
            {
                if (produit.NumeroReference == numeroReference)
                {
                    return produit;
                }
            }

            return null;
        }

        public List<Produit> Recherche(string nom)
        {
            List<Produit> produits = new List<Produit>();
            foreach (Produit produit in _produits)
            {
                if (produit.Nom == nom.Trim())
                {
                    produits.Add(produit);
                }
            }

            return produits;
        }

        public List<Produit> Recherche(Type type)
        {
            List<Produit> produits = new List<Produit>();
            foreach (Produit produit in _produits)
            {
                if (produit.GetType() == type)
                {
                    produits.Add(produit);
                }
            }

            return produits;
        }

        public List<Produit> Recherche(double minPrix, double maxPrix)
        {
            List<Produit> produits = new List<Produit>();
            foreach (Produit produit in _produits)
            {
                if (produit.Prix >= minPrix && produit.Prix <= maxPrix) 
                {
                    produits.Add(produit);
                }
            }

            return produits;
        }

        public List<Produit> GetAll()
        {         
            return _produits;
        }
    }
}
