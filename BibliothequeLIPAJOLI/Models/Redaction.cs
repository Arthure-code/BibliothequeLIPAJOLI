namespace BibliothequeLIPAJOLI.Models
{
    public class Redaction
    {
        public int LivreID { get; set; }
        public Livre Livre { get; set; }

        public int AuteurID { get; set; }
        public Auteur Auteur { get; set; }
    }
}
