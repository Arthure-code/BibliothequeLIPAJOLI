using System.ComponentModel.DataAnnotations;

namespace BibliothequeLIPAJOLI.Models
{
    public class Categorie
    {
        [Key]
        public int CategorieID { get; set; }

        [Required(ErrorMessage = "Le nom de la catégorie est obligatoire.")]
        [StringLength(50, ErrorMessage = "Le nom de la catégorie ne peut pas dépasser 50 caractères.")]
        public string? NomCategorie { get; set; }

        [StringLength(100, ErrorMessage = "Le libellé ne peut pas dépasser 100 caractères.")]
        public string? LibelleCategorie { get; set; }

        public ICollection<Livre>? Livres { get; set; }
    }
}
