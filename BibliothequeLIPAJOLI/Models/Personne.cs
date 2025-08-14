using System.ComponentModel.DataAnnotations;

namespace BibliothequeLIPAJOLI.Models
{
    public abstract class Personne
    {
        public int ID { get; set; }
        [Required]
        public string? Nom { get; set; }

        [Required]
        public string? Prenom { get; set; }

        [EmailAddress]
        public string? Courriel { get; set; }
        public DateTime? DateNaissance { get; set; }
        public string NomComplet
        {
            get
            {
                return Nom + ", " + Prenom;
            }
        }
    }
}
