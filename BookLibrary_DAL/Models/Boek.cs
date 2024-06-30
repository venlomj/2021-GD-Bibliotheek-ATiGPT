using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_DAL.Models
{
    public class Boek
    {
        public int BoekId { get; set; }
        public int CategorieId { get; set; }
        public string Naam { get; set; }
        public string Auteur { get; set; }
        public string Uitgever { get; set; }
        public string ISBN { get; set; }
        public string Leeftijdsklasse { get; set; }
        public bool IsVerkocht { get; set; }
    }
}
