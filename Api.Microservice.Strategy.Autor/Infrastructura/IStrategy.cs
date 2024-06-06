namespace Api.Microservice.Strategy.Autor.Infrastructura
{
    public interface IStrategy
    {
        public Task<object> EjecutarConsulta(object data);
    }
}
