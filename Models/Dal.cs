using System;
using System.Collections.Generic;
using System.Linq;

namespace ReservationPlace.Models
{
    // Data Access Layer : implémentation de l'interface permettant d'accéder aux données dans la base
    public class Dal : IDal
    {
        private BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }

        // Méthode permettant d'ajouter un concert dans la base
        public void CreerConcert(string nom, string artiste, DateTime dateConcert, string lieu, string salle, int nombreDePlaces)
        {
            bdd.Concerts.Add(new Concert { Nom = nom, Artiste = artiste, DateConcert = dateConcert, Lieu = lieu, Salle = salle, NombreDePlaces = nombreDePlaces });
            bdd.SaveChanges();
        }

        // Méthode permettant de récupérer soit la liste de tous les concerts, soit la liste des concerts concordant au lieu entré dans la recherche
        // Idéalement, je devrais avoir 2 méthodes séparées
        public List<Concert> ObtientTousLesConcerts(string lieu="")
        {
            if (lieu != null)
                return bdd.Concerts.Where(c=>c.Lieu==lieu).ToList();
            else
                return bdd.Concerts.ToList();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }
    }
}