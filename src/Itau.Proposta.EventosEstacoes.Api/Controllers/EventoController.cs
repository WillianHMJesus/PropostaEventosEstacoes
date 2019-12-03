using Itau.Proposta.EventosEstacoes.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Itau.Proposta.EventosEstacoes.Api.Controllers
{
    [Route("api/")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        private readonly IEventoService _eventoService;

        public EventoController(IEventoService eventoService)
        {
            _eventoService = eventoService;
        }

        [Route("eventos")]
        [HttpGet]
        public IActionResult Index()
        {
            var eventos = _eventoService.ObterEventosAleatorios();

            return Ok(eventos);
        }
    }
}