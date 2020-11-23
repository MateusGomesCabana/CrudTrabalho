using System.Collections.Generic;

namespace ProjBiblio.Domain.Entities
{
    public class CampanhaMarketing
    {
        public int CampanhaMarketingID { get; set; }

       public string Descricao { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public float? PercentualDesconto { get; set; }

        public ICollection<CampanhaMarketingLivro> CampanhaMarketingLivro { get; set; }
    }
}