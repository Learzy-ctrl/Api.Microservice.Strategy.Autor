using Api.Microservice.Strategy.Autor.Aplicacion;
using Api.Microservice.Strategy.Autor.DTOs;
using Api.Microservice.Strategy.Autor.persistencia;
using Microsoft.AspNetCore.Mvc;

namespace Api.Microservice.Strategy.Autor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly Contexto _contexto;
        private readonly ContextoAutor _contextoAutor;

        public AutorController(Contexto contexto, ContextoAutor contextoAutor)
        {
            this._contexto = contexto;
            _contextoAutor = contextoAutor;
        }

        [HttpPost]
        public async Task<ActionResult> Crear(AutorDtoEP autor)
        {
            _contexto.SetStrategy(new Nuevo(_contextoAutor));
            return await _contexto.EjecutarLogica(autor);
        }

        [HttpGet]
        public async Task<ActionResult> GetAutores()
        {
            _contexto.SetStrategy(new Consulta(_contextoAutor));
            return await _contexto.EjecutarLogica();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetAutorLibro(string id)
        {
            _contexto.SetStrategy(new ConsultaFiltro(_contextoAutor));
            return await _contexto.EjecutarLogica(id);
        }
    }
}
