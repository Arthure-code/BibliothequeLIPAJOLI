using System.ComponentModel.DataAnnotations;

namespace BibliothequeLIPAJOLI.Models
{
    public class Exemplaire
    {
        public int ExemplaireID { get; set; }
        public int Reference { get; set; }
        public int NbExemplaire { get; set; }
        public DateTime DateAchat { get; set; }
        public string? Fournisseur { get; set; }
        public int EditionID { get; set; }
        public Edition? Edition { get; set; }
        public ICollection<Emprunt>? Emprunts { get; set; }
    }
}
