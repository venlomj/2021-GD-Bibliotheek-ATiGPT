using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_DAL.Models
{
    public class Inschrijving
    {
        public int InschrijvingID { get; set; }
        public int BoekenbeursID { get; set; }
        public int GebruikerID { get; set; }

        //Navigatieproperties
        public Gebruiker Gebruiker { get; set; }
        public Boekenbeurs Boekenbeurs { get; set; }
    }
}
