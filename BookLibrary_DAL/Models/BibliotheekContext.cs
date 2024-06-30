using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_DAL.Models
{
    public class BibliotheekContext : DbContext
    {
        public BibliotheekContext()
        {

        }

        public DbSet<Boek> Boeken { get; set; }
        public DbSet<Gebruiker> Gebruikers { get; set; }
        public DbSet<Boekenbeurs> Boekenbeurzen { get; set; }
        public DbSet<Inschrijving> Inschrijvingen { get; set; }
        public DbSet<Categorie> Categorieën { get; set; }
        public DbSet<CategorieBoek> CategorieBoeken { get; set; }
    }

    //Stap 5: In package manager console het commando "enable-migrations" ingeven.

    //Stap 6: Het commando add-migration "naam" ingeven

    //Stap 7: Update database (met -verbose --> dan kan je jouw database zien) commando
}
