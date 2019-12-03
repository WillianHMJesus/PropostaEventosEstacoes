using System;

namespace Itau.Proposta.EventosEstacoes.Console.Eventos
{
    public class Evento
    {
        public Guid EventoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public bool EventoRealizado
        {
            get => (Data <= DateTime.Now)
;
        }

        public override string ToString()
        {
            return $"{ Nome } na data { Data.ToShortDateString() }";
        }
    }
}
