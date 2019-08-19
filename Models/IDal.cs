using System;
using System.Collections.Generic;

namespace ReservationPlace.Models
{
    // Interface Data Access Layer : interface permettant d'accéder aux données dans la base
    public interface IDal : IDisposable
    {
        void CreerConcert(string nom, string artiste, DateTime dateConcert, string lieu, string salle, int nombreDePlaces);
        List<Concert> ObtientTousLesConcerts(string lieu="");
    }
}