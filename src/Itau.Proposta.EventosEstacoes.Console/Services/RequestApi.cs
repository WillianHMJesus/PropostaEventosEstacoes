using System;
using System.Net.Http;

namespace Itau.Proposta.EventosEstacoes.Console.Services
{
    public class RequestApi : IRequestApi
    {
        private readonly HttpClient _client;

        public RequestApi()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44310/")
            };
        }

        public HttpResponseMessage ObterEventos()
        {
            using (var client = new HttpClient())
            {
                return _client.GetAsync("api/eventos").Result;
            }
        }
    }
}
