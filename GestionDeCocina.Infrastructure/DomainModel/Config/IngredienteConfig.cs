using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.Ingredientes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestionDeCocina.Infrastructure.DomainModel.Config
{
    internal class IngredienteConfig: IEntityTypeConfiguration<Ingrediente>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Ingrediente> builder)
        {
            builder.ToTable("ingrediente");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("ingredienteId");
            builder.Property(x => x.Name)
                .HasColumnName("ingredienteName");

          
        }
    }
}
