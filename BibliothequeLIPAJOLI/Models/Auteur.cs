using System.ComponentModel.DataAnnotations;

namespace BibliothequeLIPAJOLI.Models
{
    public class Auteur
    {
        [Key]
        public int AuteurID { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire.")]
        [StringLength(50, ErrorMessage = "Le nom ne peut pas dépasser 50 caractères.")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Le prénom est obligatoire.")]
        [StringLength(50, ErrorMessage = "Le prénom ne peut pas dépasser 50 caractères.")]
        public string Prenom { get; set; }

        [EmailAddress(ErrorMessage = "Adresse courriel invalide.")]
        public string Courriel { get; set; }

        [Required(ErrorMessage = "La date de naissance est obligatoire.")]
        [DataType(DataType.Date)]
        public DateTime DateNaissance { get; set; }

        public ICollection<Redaction> Redactions { get; set; }
    }
}
