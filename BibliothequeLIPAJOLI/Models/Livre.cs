using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace BibliothequeLIPAJOLI.Models
{
    public class Livre
    {
        [Key]
        public int LivreID { get; set; }

        [Required(ErrorMessage = "Le titre est obligatoire.")]
        [StringLength(100, ErrorMessage = "Le titre ne peut pas dépasser 100 caractères.")]
        public string Titre { get; set; }

        [Range(1000, 2100, ErrorMessage = "L'année doit être comprise entre 1000 et 2100.")]
        public int Annee { get; set; }

        [StringLength(500, ErrorMessage = "Le résumé ne peut pas dépasser 500 caractères.")]
        public string Resume { get; set; }

        [Required(ErrorMessage = "La catégorie est obligatoire.")]
        public int CategorieID { get; set; }
        public Categorie Categorie { get; set; }

        public ICollection<Edition> Editions { get; set; }
        public ICollection<Redaction> Redactions { get; set; }
    }
}
