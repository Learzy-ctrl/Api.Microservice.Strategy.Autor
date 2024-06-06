using Api.Microservice.Strategy.Autor.Modelo;
using Microsoft.EntityFrameworkCore;

namespace Api.Microservice.Strategy.Autor.persistencia
{
    public class ContextoAutor : DbContext
    {
        public ContextoAutor(DbContextOptions<ContextoAutor> options) : base(options)
        {

        }

        public DbSet<AutorLibro> AutorLibros { get; set; }
        public DbSet<GradoAcademico> GradoAcademicos { get; set; }
    }
}
