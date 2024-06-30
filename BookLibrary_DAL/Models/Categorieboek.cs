using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_DAL.Models
{
    [Table("CategorieBoeken")]
    public class CategorieBoek
    {
        // Auto properties met toegeweze attributen
        [Key]
        public int CategorieBoekID { get; set; }

        [Required]
        [Index("BoekIDCategorieID", 1, IsUnique = true)]
        public int BoekId { get; set; }

        [Required]
        [Index("BoekIDCategorieID", 2, IsUnique = true)]
        public int CategorieID { get; set; }

        // Navigatieproperties
        public Categorie Categorie { get; set; }
        public Boek Boek { get; set; }
    }
}
