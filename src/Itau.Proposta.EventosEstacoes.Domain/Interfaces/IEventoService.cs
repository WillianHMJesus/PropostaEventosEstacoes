using Itau.Proposta.EventosEstacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itau.Proposta.EventosEstacoes.Domain.Interfaces
{
    public interface IEventoService
    {
        IEnumerable<Evento> ObterEventosAleatorios();
    }
}
