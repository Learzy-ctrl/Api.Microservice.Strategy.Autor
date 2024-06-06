using Api.Microservice.Strategy.Autor.Infrastructura;
using Api.Microservice.Strategy.Autor.persistencia;
using Microsoft.EntityFrameworkCore;

namespace Api.Microservice.Strategy.Autor.Aplicacion
{
    public class ConsultaFiltro : IStrategy
    {
        private readonly ContextoAutor _contexto;

        public ConsultaFiltro(ContextoAutor contexto)
        {
            _contexto = contexto;
        }

        public async Task<object> EjecutarConsulta(object data)
        {
            string guid = data.ToString();
            var autores = await _contexto.AutorLibros.Where(a => a.AutorLibroGuid == guid).FirstOrDefaultAsync();
            return autores;
        }
    }
}
