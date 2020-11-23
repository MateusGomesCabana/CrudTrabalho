using ProjBiblio.Application.InputModels;
using ProjBiblio.Application.ViewModels;

namespace ProjBiblio.Application.Interfaces
{
    public interface ICampanhaMarketingService
    {
        CampanhaMarketingListViewModel Get();

        CampanhaMarketingViewModel Get(int id);

        CampanhaMarketingViewModel Post(CampanhaMarketingInputModel CampanhaMarketing);

        CampanhaMarketingViewModel Put(int id, CampanhaMarketingInputModel CampanhaMarketing);

        CampanhaMarketingViewModel Delete(int id);
    }
}