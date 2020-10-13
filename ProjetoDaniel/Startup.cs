using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProjetoDaniel.Data.Context;
using ProjetoDaniel.Data.Repository;
using ProjetoDaniel.Domain.Interfaces.Repositories;
using ProjetoDaniel.Domain.Interfaces.Services;
using ProjetoDaniel.Domain.Services;
using ProjetoDanielApplication.Interfaces;
using ProjetoDanielApplication.Services;

namespace ProjetoDaniel
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(o =>
                o.UseSqlServer(Configuration["connectionStrings:default"]));
            services.AddScoped<IPizzaRepository, PizzaRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IPizzaAppService, PizzaAppService>();
            services.AddScoped<IPedidoAppService, PedidoAppService>();
            services.AddScoped<IPizzaService, PizzaService>();
            services.AddScoped<IPedidoService, PedidoService>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ITipoPizzaRepository, TipoPizzaRepository>();
            services.AddScoped<IClienteAppService, ClienteAppService>();
            services.AddScoped<ITipoPizzaAppSevice, TipoPizzaAppService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<ITipoPizzaService, TipoPizzaService>();

            services.AddScoped<IPorcaoRepository, PorcaoRepository>();
            services.AddScoped<IPorcaoAppService, PorcaoAppService>();
            services.AddScoped<IPorcaoService, PorcaoService>();

            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
            services.AddAutoMapper();
            services.AddCors(o => o.AddPolicy("any", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.Configure<MvcOptions>(options =>
            {
                options.Filters.Add(new CorsAuthorizationFilterFactory("any"));
            }); ;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("AllowAll");
            app.UseMvc();
        }
    }
}
