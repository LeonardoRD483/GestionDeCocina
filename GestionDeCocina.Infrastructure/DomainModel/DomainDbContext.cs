using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.abstractions;
using GestionDeCocina.Domain.Ingredientes;
using GestionDeCocina.Domain.Paquete;
using GestionDeCocina.Domain.RecetaAndIngredientes;
using GestionDeCocina.Domain.Recetas;
using Microsoft.EntityFrameworkCore;

namespace GestionDeCocina.Infrastructure.DomainModel
{
    internal class DomainDbContext : DbContext
    {

        public DbSet<Ingrediente> _ingredientes { get; set; }
        public DbSet<Receta> _recetas { get; set; }
        public DbSet<RecetaAndIngredientes> _recetaAndIngredientes { get; set; }
        public DbSet<Paquete> _paquete { get; set; }
        public DbSet<PaqueteAndReceta> _paqueteAndReceta { get; set; }

        public DomainDbContext(DbContextOptions<DomainDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DomainDbContext).Assembly);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Ignore<DomainEvent>();
        }
    }
}
