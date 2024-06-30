using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_DAL.Models
{
    [Table("Categorieën")]
    public class Categorie
    {
        // Auto properties met toegeweze attributen
        [Key]
        public int CategorieID { get; set; }

        [Required]
        public string Naam { get; set; }

        // Navigatieproperties
        public ICollection<CategorieBoek> CategorieBoeken { get; set; }
    }
}
