using Api.Microservice.Strategy.Autor.Infrastructura;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Api.Microservice.Strategy.Autor.persistencia
{
    public class Contexto
    {
        private IStrategy _strategy;
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public async Task<JsonResult> EjecutarLogica(object data)
        {
            var result = await _strategy.EjecutarConsulta(data);
            var respuesta = new
            {
                request = result
            };
            return new JsonResult(respuesta);
        }
        public async Task<JsonResult> EjecutarLogica()
        {
            var result = await _strategy.EjecutarConsulta(null);
            var respuesta = new
            {
                request = result
            };
            return new JsonResult(respuesta);
        }
    }
}
