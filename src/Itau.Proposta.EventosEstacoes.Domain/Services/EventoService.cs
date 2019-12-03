using Itau.Proposta.EventosEstacoes.Domain.Entities;
using Itau.Proposta.EventosEstacoes.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Itau.Proposta.EventosEstacoes.Domain.Services
{
    public class EventoService : IEventoService
    {
        private readonly IEventoRepository _eventoRepository;
        private readonly Random _random;

        public EventoService(IEventoRepository eventoRepository, Random random)
        {
            _eventoRepository = eventoRepository;
            _random = random;
        }

        public IEnumerable<Evento> ObterEventosAleatorios()
        {
            return (from evento in _eventoRepository.ObterEventos().ToList()
                    let random = _random.Next()
                    orderby random
                    select evento).ToList();
        }
    }
}
