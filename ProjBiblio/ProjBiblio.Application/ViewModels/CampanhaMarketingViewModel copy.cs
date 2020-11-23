namespace ProjBiblio.Application.ViewModels
{
    public class CampanhaMarketingViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public float? PercentualDesconto { get; set; }
    }
}