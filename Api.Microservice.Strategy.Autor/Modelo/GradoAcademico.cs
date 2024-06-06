namespace Api.Microservice.Strategy.Autor.Modelo
{
    public class GradoAcademico
    {
        public int GradoAcademicoId { get; set; }
        public string nombre { get; set; }
        public string CentroAcademico { get; set; }
        public DateTime? FechaGrado { get; set; }
        public int AutorLibroId { get; set; }
        public AutorLibro AutorLibro { get; set; }
        public string GradoAcademicoGuid { get; set; }
    }
}
