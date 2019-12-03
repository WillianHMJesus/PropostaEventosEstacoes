using Itau.Proposta.EventosEstacoes.Domain.Entities;
using System.Collections.Generic;

namespace Itau.Proposta.EventosEstacoes.Domain.Interfaces
{
    public interface IEventoRepository
    {
        IEnumerable<Evento> ObterEventos();
    }
}
