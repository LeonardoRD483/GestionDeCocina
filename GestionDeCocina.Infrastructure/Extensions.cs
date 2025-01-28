using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Application;
using GestionDeCocina.Domain.abstractions;
using GestionDeCocina.Domain.Ingredientes;
using GestionDeCocina.Domain.Paquete;
using GestionDeCocina.Domain.RecetaAndIngredientes;
using GestionDeCocina.Domain.Recetas;
using GestionDeCocina.Infrastructure.DomainModel;
using GestionDeCocina.Infrastructure.Repositories;
using GestionDeCocina.Infrastructure.StoredModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GestionDeCocina.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructura(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(config =>
              config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly())
          );
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<StoredDbContext>(context => context.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
            services.AddDbContext<DomainDbContext>(context => context.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
            services.AddScoped<IIngredienteReposaitory, IngredienteRepository>();
            services.AddScoped<IRecetaReposaitory, RecetaRepository>();
            services.AddScoped<IRecetaAndIngredienteReposaitory, RecetaAndIngredienteRepository>();
            services.AddScoped<IPaqueteRepository, PaqueteRepository>();
            services.AddScoped<IPaqueteAndRecetaReposaitory, PaqueteAndRecetaRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAplication();
            return services;
        }
    }
}
