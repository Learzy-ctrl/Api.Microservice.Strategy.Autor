using Api.Microservice.Strategy.Autor.Infrastructura;
using Api.Microservice.Strategy.Autor.persistencia;
using Microsoft.EntityFrameworkCore;

namespace Api.Microservice.Strategy.Autor.Aplicacion
{
    public class Consulta : IStrategy
    {
        private readonly ContextoAutor _contexto;

        public Consulta(ContextoAutor contexto)
        {
            _contexto = contexto;
        }
        public async Task<object> EjecutarConsulta(object data)
        {
            var autores = await _contexto.AutorLibros.ToListAsync();
            return autores;
        }

    }
}
