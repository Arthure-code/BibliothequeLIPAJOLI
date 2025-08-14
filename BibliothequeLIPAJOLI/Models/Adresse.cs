using System.ComponentModel.DataAnnotations;

namespace BibliothequeLIPAJOLI.Models
{
    public class Adresse
    {
        [Key]
        public int AdresseID { get; set; }

        [Required(ErrorMessage = "La rue est obligatoire.")]
        [StringLength(100)]
        public string? Rue { get; set; }

        [Required(ErrorMessage = "La ville est obligatoire.")]
        [StringLength(50)]
        public string? Ville { get; set; }

        [Required(ErrorMessage = "La province est obligatoire.")]
        [StringLength(50)]
        public string? Province { get; set; }

        [Required(ErrorMessage = "Le code postal est obligatoire.")]
        [StringLength(10)]
        public string? CodePostale { get; set; }

        public ICollection<TypeAdresse>? UsagerAdresse { get; set; }
    }
}
