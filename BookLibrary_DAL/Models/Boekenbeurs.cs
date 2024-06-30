using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_DAL.Models
{
    public class Boekenbeurs
    {
        public int BoekenbeursID { get; set; }
        public string Locatie { get; set; }
        public string Naam { get; set; }

        //Navigatieproperties
        public ICollection<Inschrijving> Inschrijvingen { get; set; }
    }
}
