using Api.Microservice.Strategy.Autor.DTOs;
using Api.Microservice.Strategy.Autor.Infrastructura;
using Api.Microservice.Strategy.Autor.Modelo;
using Api.Microservice.Strategy.Autor.persistencia;

namespace Api.Microservice.Strategy.Autor.Aplicacion
{
    public class Nuevo : IStrategy
    {
        private readonly ContextoAutor _contexto;

        public Nuevo(ContextoAutor contexto)
        {
            _contexto = contexto;
        }
        public async Task<object> EjecutarConsulta(object data)
        {
            var autor = data as AutorDtoEP;
            var autorLibro = new AutorLibro
            {
                Nombre = autor.Nombre,
                Apellido = autor.Apellido,
                FechaNacimiento = autor.FechaNacimiento,
                AutorLibroGuid = Convert.ToString(Guid.NewGuid())
            };
            await _contexto.AutorLibros.AddAsync(autorLibro);
            return await _contexto.SaveChangesAsync();
        }
    }
}
