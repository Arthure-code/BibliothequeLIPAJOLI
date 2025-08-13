using System.ComponentModel.DataAnnotations;

namespace BibliothequeLIPAJOLI.Models
{
    public class Usager
    {
        [Key]
        public int UsagerID { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire.")]
        [StringLength(50, ErrorMessage = "Le nom ne peut pas dépasser 50 caractères.")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Le prénom est obligatoire.")]
        [StringLength(50, ErrorMessage = "Le prénom ne peut pas dépasser 50 caractères.")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "L'adresse courriel est obligatoire.")]
        [EmailAddress(ErrorMessage = "Adresse courriel invalide.")]
        public string Courriel { get; set; }

        [Required(ErrorMessage = "La date de naissance est obligatoire.")]
        [DataType(DataType.Date)]
        public DateTime DateNaissance { get; set; }

        [Required(ErrorMessage = "Le numéro d'identité est obligatoire.")]
        public string NumeroIdentite { get; set; }

        [StringLength(15)]
        public string? NAS { get; set; }

        [Phone(ErrorMessage = "Numéro de téléphone invalide.")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Le type d'usager est obligatoire.")]
        public string TypeUsager { get; set; }

        public ICollection<Emprunt>? Emprunts { get; set; }
        public ICollection<TypeAdresse> TypeAdresses { get; set; }
    }
}
