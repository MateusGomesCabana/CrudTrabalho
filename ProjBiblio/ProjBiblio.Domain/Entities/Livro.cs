using System.Collections.Generic;

namespace ProjBiblio.Domain.Entities
{
    public class Livro
    {
        public int LivroID { get; set; }

        public string Titulo { get; set; }

        public int? Quantidade { get; set; }

        public string Foto { get; set; }
        public int Ano { get; set; }
        public int Edicao { get; set; }
        public int Pagina { get; set; }
        public string Editora { get; set; }

        public virtual Genero Genero { get; set; }

        public ICollection<LivroAutor> LivAutor { get; set; }

        public ICollection<LivroEmprestimo> LivEmprestimo { get; set; }

        public ICollection<CampanhaMarketingLivro> CampanhaMarketingLivro { get; set; }
    }
}