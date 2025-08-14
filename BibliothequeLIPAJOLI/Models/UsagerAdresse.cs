using System.ComponentModel.DataAnnotations;

namespace BibliothequeLIPAJOLI.Models
{

    public enum TypeAdresse
    {
        Principale,
        Secondaire,
        Bureau,
        Autre
    }
    public class UsagerAdresse
    {
        public int UsagerID { get; set; }
        public Usager? Usager { get; set; }

        public int AdresseID { get; set; }
        public Adresse? Adresse { get; set; }

        [Required(ErrorMessage = "Le type d'adresse est obligatoire.")]
        public TypeAdresse TypeAdresse { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
    }
}
