using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.RecetaAndIngredientes;
using Microsoft.EntityFrameworkCore;

namespace GestionDeCocina.Infrastructure.DomainModel.Config
{

    internal class PaqueteAndRecetaConfig : IEntityTypeConfiguration<PaqueteAndReceta>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PaqueteAndReceta> builder)
        {
            builder.ToTable("paqueteAndReceta");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("paqueteAndRecetaId");
            builder.Property(x => x.paquete)
                .HasColumnName("paqueteId");
            builder.Property(x => x.receta)
                .HasColumnName("recetaId");
        }
    }
}
