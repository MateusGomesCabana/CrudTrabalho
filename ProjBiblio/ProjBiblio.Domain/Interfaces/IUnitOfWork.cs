using ProjBiblio.Domain.Interfaces;

namespace ProjBiblio.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IAutorRepository AutorRepository { get; }

        ILivroRepository LivroRepository { get; }

        ICampanhaMarketingRepository CampanhaMarketingRepository { get; }

        IGeneroRepository GeneroRepository { get; }
         void Commit();
    }
}