using System.Net.Http;

namespace Itau.Proposta.EventosEstacoes.Console.Services
{
    public interface IRequestApi
    {
        HttpResponseMessage ObterEventos();
    }
}
