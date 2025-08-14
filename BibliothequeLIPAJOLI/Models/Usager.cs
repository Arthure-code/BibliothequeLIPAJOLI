using System.ComponentModel.DataAnnotations;

namespace BibliothequeLIPAJOLI.Models
{
    public enum TypeUsager
    {
        Etudiant,
        Enseignant,
        Employe,
        Visiteur,
        Autre
    }
    public class Usager : Personne
    {

        [Required(ErrorMessage = "Le numéro d'identité est obligatoire.")]
        public string? NumeroIdentite { get; set; }

        [StringLength(15)]
        public string? NAS { get; set; }

        [Phone(ErrorMessage = "Numéro de téléphone invalide.")]
        public string? Telephone { get; set; }

        [Required(ErrorMessage = "Le type d'usager est obligatoire.")]
        public TypeUsager TypeUsager { get; set; }

        public ICollection<Emprunt>? Emprunts { get; set; }
        public ICollection<UsagerAdresse>? TypeAdresses { get; set; }
    }
}
