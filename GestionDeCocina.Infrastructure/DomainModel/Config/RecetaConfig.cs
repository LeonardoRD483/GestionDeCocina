using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.Ingredientes;
using GestionDeCocina.Domain.Recetas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestionDeCocina.Infrastructure.DomainModel.Config
{

    internal class RecetaConfig : IEntityTypeConfiguration<Receta>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Receta> builder)
        {
            builder.ToTable("receta");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("recetaId");
            builder.Property(x => x.Name)
                .HasColumnName("recetaName");


        }

    }
}
