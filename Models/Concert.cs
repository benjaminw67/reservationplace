using System;

namespace ReservationPlace.Models
{
    public class Concert
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Artiste { get; set; }
        public DateTime DateConcert { get; set; }
        public string Lieu { get; set; }
        public string Salle { get; set; }
        public int NombreDePlaces { get; set; }
    }
}