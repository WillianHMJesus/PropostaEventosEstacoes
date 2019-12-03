using Itau.Proposta.EventosEstacoes.Data.Repository;
using Itau.Proposta.EventosEstacoes.Domain.Interfaces;
using Itau.Proposta.EventosEstacoes.Domain.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Itau.Proposta.EventosEstacoes.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //Injeção de Dependência
            services.AddSingleton<IEventoRepository, EventoRepository>();
            services.AddSingleton<IEventoService, EventoService>();
            services.AddSingleton<Random>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
