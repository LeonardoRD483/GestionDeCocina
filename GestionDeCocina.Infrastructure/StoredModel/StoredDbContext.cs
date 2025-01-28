using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Infrastructure.StoredModel.Entities;
using Microsoft.EntityFrameworkCore;

namespace GestionDeCocina.Infrastructure.StoredModel
{
    internal class StoredDbContext: DbContext
    {
        public DbSet<IngredienteStoredModel> Ingrediente{ get; set; }
        public DbSet<RecetaStoredModel> Receta{ get; set; }
        public DbSet<recetaAndIngrediente> RecetaAndIngredientes{ get; set; }
        public DbSet<PaqueteStoredModel> Paquete{ get; set; }
        public DbSet<PaqueteAndRecetaStoredModel> PaqueteAndReceta{ get; set; }
        
        public StoredDbContext(DbContextOptions<StoredDbContext> options) : base(options) { 
        }
    }
}
