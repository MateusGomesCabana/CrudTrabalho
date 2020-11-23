using FluentValidation;

namespace ProjBiblio.Application.InputModels {
    public class GeneroInputModel {
        public int Id { get; set; }
        public string Descricao { get; set; }
      

    }

    public class GeneroInputModelValidator : AbstractValidator<GeneroInputModel> {
        public GeneroInputModelValidator () {
            RuleFor (x => x.Descricao).NotEmpty ().WithMessage ("A descrição é obrigatória.")
                .Length (0, 100).WithMessage ("A descrição não pode exceder 100 caracteres.");

        }
    }
}