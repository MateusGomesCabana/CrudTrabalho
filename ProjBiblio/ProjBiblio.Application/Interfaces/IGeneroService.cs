using ProjBiblio.Application.InputModels;
using ProjBiblio.Application.ViewModels;

namespace ProjBiblio.Application.Interfaces
{
    public interface IGeneroService
    {
        GeneroListViewModel Get();

        GeneroViewModel Get(int id);

        GeneroViewModel Post(GeneroInputModel Genero);

        GeneroViewModel Put(int id, GeneroInputModel Genero);

        GeneroViewModel Delete(int id);
    }
}