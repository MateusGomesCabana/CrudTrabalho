using FluentValidation;

namespace ProjBiblio.Application.InputModels {
    public class LivroInputModel {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public int? Quantidade { get; set; }

        public string Foto { get; set; }
        public int Ano { get; set; }
        public int Edicao { get; set; }
        public int Pagina { get; set; }
        public string Editora { get; set; }

    }

    public class LivroInputModelValidator : AbstractValidator<LivroInputModel> {
        public LivroInputModelValidator () {
            RuleFor (x => x.Titulo).NotEmpty ().WithMessage ("O Nome é obrigatório.")
                .Length (0, 100).WithMessage ("O Nome não pode exceder 100 caracteres.");

            RuleFor (x => x.Quantidade)
                .GreaterThanOrEqualTo (0).WithMessage ("A quantidade não pode ter valor negativo.");

            RuleFor (x => x.Foto).Length (0, 300).WithMessage ("O Nome não pode exceder 300 caracteres.");

            RuleFor (x => x.Ano)
                .GreaterThanOrEqualTo (0).WithMessage ("O ano não pode ter valor negativo.");
            RuleFor (x => x.Edicao)
                .GreaterThanOrEqualTo (0).WithMessage ("A Edicao não pode ter valor negativo.");
            RuleFor (x => x.Pagina)
                .GreaterThanOrEqualTo (0).WithMessage ("A qtde de Pagina não pode ter valor negativo.");
            RuleFor (x => x.Editora).NotEmpty ().WithMessage ("A Editora é obrigatório.")
                .Length (0, 100).WithMessage ("A Editora não pode exceder 100 caracteres.");
        }
    }
}