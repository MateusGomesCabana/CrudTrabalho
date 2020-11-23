namespace ProjBiblio.Domain.Entities
{
    public class CampanhaMarketingLivro
    {
        public int CampanhaMarketingID { get; set; }
        public CampanhaMarketing CampanhaMarketing { get; set; }

        public int LivroID { get; set; }
        public Livro Livro { get; set; }
    }
}