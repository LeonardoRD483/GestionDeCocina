using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.Ingredientes;
using GestionDeCocina.Domain.RecetaAndIngredientes;
using Microsoft.EntityFrameworkCore;

namespace GestionDeCocina.Infrastructure.DomainModel.Config
{

    internal class RecetaAndIngredientesConfig : IEntityTypeConfiguration<RecetaAndIngredientes>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<RecetaAndIngredientes> builder)
        {
            builder.ToTable("recetaAndIngrediente");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("recetaAndIngredienteId");
            builder.Property(x => x.receta)
                .HasColumnName("recetaId");
            builder.Property(x => x.ingrediente)
                .HasColumnName("ingredienteId");


        }
    }
}
