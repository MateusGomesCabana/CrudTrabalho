using FluentValidation;

namespace ProjBiblio.Application.InputModels {
    public class CampanhaMarketingInputModel {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public float? PercentualDesconto { get; set; }

    }

    public class CampanhaMarketingInputModelValidator : AbstractValidator<CampanhaMarketingInputModel> {
        public CampanhaMarketingInputModelValidator () {
            RuleFor (x => x.Descricao).NotEmpty ().WithMessage ("A descrição é obrigatória.")
                .Length (0, 100).WithMessage ("A descrição não pode exceder 100 caracteres.");

            RuleFor (x => x.DataInicio).NotEmpty ().WithMessage ("A DataInicio é obrigatória.");

            RuleFor (x => x.DataFim).NotEmpty ().WithMessage ("A descrição é obrigatória.");
        }
    }
}