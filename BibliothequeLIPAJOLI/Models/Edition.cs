using System.ComponentModel.DataAnnotations;

namespace BibliothequeLIPAJOLI.Models
{
    public class Edition
    {
        [Key]
        public int EditionID { get; set; }

        [Required(ErrorMessage = "Le nom de l'éditeur est obligatoire.")]
        [StringLength(100, ErrorMessage = "Le nom de l'éditeur ne peut pas dépasser 100 caractères.")]
        public string NomEditeur { get; set; }

        [Required(ErrorMessage = "Le livre est obligatoire.")]
        public int LivreID { get; set; }
        public Livre Livre { get; set; }

        public ICollection<Exemplaire> Exemplaires { get; set; }
    }
}
