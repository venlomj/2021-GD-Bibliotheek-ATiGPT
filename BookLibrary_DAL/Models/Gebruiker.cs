using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_DAL.Models
{
    public class Gebruiker
    {
        public int GebruikerID { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Straat { get; set; }
        public string Gemeente { get; set; }
        public string Postcode { get; set; }
        public string Email { get; set; }
        public bool IsLid { get; set; }

        //Navigatieproperties
        public ICollection<Inschrijving> Inschrijvingen { get; set; }

    }
}
