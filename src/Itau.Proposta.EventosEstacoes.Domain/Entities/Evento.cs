using System;

namespace Itau.Proposta.EventosEstacoes.Domain.Entities
{
    public class Evento
    {
        public Guid EventoId { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public DateTime Data { get; private set; }

        public Evento(string nome, string descricao, DateTime data)
        {
            EventoId = Guid.NewGuid();
            Nome = nome;
            Descricao = descricao;
            Data = data;
        }
    }
}
