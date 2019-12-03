using Itau.Proposta.EventosEstacoes.Domain.Entities;
using Itau.Proposta.EventosEstacoes.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Itau.Proposta.EventosEstacoes.Data.Repository
{
    public class EventoRepository : IEventoRepository
    {
        public IEnumerable<Evento> ObterEventos()
        {
            return new List<Evento>()
            {
                new Evento("Evento 1", "Evento da estação 1", new DateTime(2018, 12, 10)),
                new Evento("Evento 2", "Evento da estação 2", new DateTime(2019, 12, 31)),
                new Evento("Evento 3", "Evento da estação 3", new DateTime(2019, 03, 20)),
                new Evento("Evento 4", "Evento da estação 4", new DateTime(2020, 1, 15)),
                new Evento("Evento 5", "Evento da estação 5", new DateTime(2017, 6, 2)),
                new Evento("Evento 6", "Evento da estação 6", new DateTime(2020, 8, 21)),
                new Evento("Evento 7", "Evento da estação 7", new DateTime(2019, 10, 6)),
                new Evento("Evento 8", "Evento da estação 8", new DateTime(2019, 12, 25)),
                new Evento("Evento 9", "Evento da estação 9", new DateTime(2019, 7, 18)),
                new Evento("Evento 10", "Evento da estação 10", DateTime.Now),
            };
        }
    }
}
