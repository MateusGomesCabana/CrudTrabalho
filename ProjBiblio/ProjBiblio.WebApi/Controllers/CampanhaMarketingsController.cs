using Microsoft.AspNetCore.Mvc;
using ProjBiblio.Application.InputModels;
using ProjBiblio.Application.Interfaces;
using ProjBiblio.Application.ViewModels;

namespace ProjBiblio.WebApi.Controllers
{
    [ApiController]
    [Route("CampanhaMarketings")]

    public class CampanhaMarketingsController  : ControllerBase
    {
        private ICampanhaMarketingService _CampanhaMarketingService;

        public CampanhaMarketingsController(ICampanhaMarketingService CampanhaMarketingService)
        {
            this._CampanhaMarketingService = CampanhaMarketingService;
        }

        [HttpGet]
        public CampanhaMarketingListViewModel Get()
        {
            return _CampanhaMarketingService.Get();
        }

        [HttpGet("{id}", Name="GetCampanhaMarketingsDetails")]
        public ActionResult<CampanhaMarketingViewModel> Get(int id) 
        { 
            var result = _CampanhaMarketingService.Get(id);

            if (result == null)
                return NotFound();

            return _CampanhaMarketingService.Get(id);
        }

        [HttpPost]
        public ActionResult Post([FromBody] CampanhaMarketingInputModel CampanhaMarketing)
        {
            var result = _CampanhaMarketingService.Post(CampanhaMarketing);

            return new CreatedAtRouteResult("GetCampanhaMarketingsDetails", 
                new { id = result.Id}, result);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CampanhaMarketingInputModel CampanhaMarketing)
        {
            if (id != CampanhaMarketing.Id)
            {
                return BadRequest();
            }

            var result = _CampanhaMarketingService.Put(id, CampanhaMarketing);

            return new CreatedAtRouteResult("GetCampanhaMarketingsDetails", 
                new { id = result.Id }, result);
        }

        [HttpDelete("{id}")]
        public ActionResult<CampanhaMarketingViewModel> Delete(int id)
        {
            var result = _CampanhaMarketingService.Delete(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }
    }
}