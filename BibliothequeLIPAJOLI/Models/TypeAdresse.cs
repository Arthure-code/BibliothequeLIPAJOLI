using System.ComponentModel.DataAnnotations;

namespace BibliothequeLIPAJOLI.Models
{
    public class TypeAdresse
    {
        public int UsagerID { get; set; }
        public Usager? Usager { get; set; }

        public int AdresseID { get; set; }
        public Adresse? Adresse { get; set; }

        [Required(ErrorMessage = "Le type d'adresse est obligatoire.")]
        public string TypeAdresseLibelle { get; set; }
    }
}
