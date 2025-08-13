using System.ComponentModel.DataAnnotations;

namespace BibliothequeLIPAJOLI.Models
{
    public class Emprunt
    {
        [Key]
        public int EmpruntID { get; set; }

        [Required(ErrorMessage = "La date d'emprunt est obligatoire.")]
        [DataType(DataType.Date)]
        public DateTime DateEmprunt { get; set; }

        [Required(ErrorMessage = "La date de retour prévue est obligatoire.")]
        [DataType(DataType.Date)]
        public DateTime DateProbableRetour { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateRetour { get; set; }

        [Required(ErrorMessage = "L'exemplaire est obligatoire.")]
        public int ExemplaireID { get; set; }
        public Exemplaire Exemplaire { get; set; }

        [Required(ErrorMessage = "L'usager est obligatoire.")]
        public int UsagerID { get; set; }
        public Usager Usager { get; set; }
    }
}
