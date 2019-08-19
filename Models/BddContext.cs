using Microsoft.EntityFrameworkCore;

namespace ReservationPlace.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            // Chaîne de connexion à la base de données
            optionsBuilder.UseSqlServer(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=ReservationPlace.Models.BddContext;Integrated Security=True;");
        }
    }
}