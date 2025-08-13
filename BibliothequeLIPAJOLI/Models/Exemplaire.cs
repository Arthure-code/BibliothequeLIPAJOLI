using System.ComponentModel.DataAnnotations;

namespace BibliothequeLIPAJOLI.Models
{
    public class Exemplaire
    {
        [Key]
        public int ExemplaireID { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Le nombre d'exemplaires doit être supérieur à zéro.")]
        public int NombreExemplaire { get; set; }

        [Required(ErrorMessage = "La date d'achat est obligatoire.")]
        [DataType(DataType.Date)]
        public DateTime DateAchat { get; set; }

        [StringLength(50, ErrorMessage = "La position en rayon ne peut pas dépasser 50 caractères.")]
        public string PositionRayon { get; set; }

        [StringLength(100, ErrorMessage = "Le nom du fournisseur ne peut pas dépasser 100 caractères.")]
        public string? Fournisseur { get; set; }

        [Required(ErrorMessage = "L'édition est obligatoire.")]
        public int EditionID { get; set; }
        public Edition Edition { get; set; }

        public ICollection<Emprunt>? Emprunts { get; set; }
    }
}
