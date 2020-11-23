namespace ProjBiblio.Application.ViewModels
{
    public class LivroViewModel
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public int? Quantidade { get; set; }

        public string Foto { get; set; }

        public int Ano { get; set; }
        public int Edicao { get; set; }
        public int Pagina { get; set; }
        public string Editora { get; set; }
    }
}