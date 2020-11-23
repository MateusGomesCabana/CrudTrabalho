using Microsoft.AspNetCore.Mvc;
using ProjBiblio.Application.InputModels;
using ProjBiblio.Application.Interfaces;
using ProjBiblio.Application.ViewModels;

namespace ProjBiblio.WebApi.Controllers
{
    [ApiController]
    [Route("Generos")]

    public class GenerosController  : ControllerBase
    {
        private IGeneroService _GeneroService;

        public GenerosController(IGeneroService GeneroService)
        {
            this._GeneroService = GeneroService;
        }

        [HttpGet]
        public GeneroListViewModel Get()
        {
            return _GeneroService.Get();
        }

        [HttpGet("{id}", Name="GetGenerosDetails")]
        public ActionResult<GeneroViewModel> Get(int id) 
        { 
            var result = _GeneroService.Get(id);

            if (result == null)
                return NotFound();

            return _GeneroService.Get(id);
        }

        [HttpPost]
        public ActionResult Post([FromBody] GeneroInputModel Genero)
        {
            var result = _GeneroService.Post(Genero);

            return new CreatedAtRouteResult("GetGenerosDetails", 
                new { id = result.Id}, result);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] GeneroInputModel Genero)
        {
            if (id != Genero.Id)
            {
                return BadRequest();
            }

            var result = _GeneroService.Put(id, Genero);

            return new CreatedAtRouteResult("GetGenerosDetails", 
                new { id = result.Id }, result);
        }

        [HttpDelete("{id}")]
        public ActionResult<GeneroViewModel> Delete(int id)
        {
            var result = _GeneroService.Delete(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }
    }
}