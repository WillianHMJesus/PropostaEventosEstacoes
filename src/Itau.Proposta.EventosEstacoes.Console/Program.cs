using Itau.Proposta.EventosEstacoes.Console.Eventos;
using Itau.Proposta.EventosEstacoes.Console.Services;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Itau.Proposta.EventosEstacoes.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IRequestApi, RequestApi>()
                .BuildServiceProvider();
            var requestapi = serviceProvider.GetService<IRequestApi>();
            var eventosResponse = requestapi.ObterEventos();

            if (eventosResponse.IsSuccessStatusCode)
            {
                var eventos = JsonConvert.DeserializeObject<List<Evento>>(eventosResponse.Content.ReadAsStringAsync().Result);
                var eventosRealizados = new List<Evento>();
                var eventosNaoRealizados = new List<Evento>();

                foreach (var evento in eventos)
                {
                    if (evento.EventoRealizado)
                    {
                        eventosRealizados.Add(evento);
                        System.Console.WriteLine(string.Format("{0} - Já foi realizado", evento.ToString()));
                    }
                    else
                    {
                        eventosNaoRealizados.Add(evento);
                    }
                }
            }


            System.Console.ReadKey();
        }
    }
}
