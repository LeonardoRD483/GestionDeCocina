using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCocina.Domain.Ingredientes;
using GestionDeCocina.Domain.Paquete;
using Microsoft.EntityFrameworkCore;

namespace GestionDeCocina.Infrastructure.DomainModel.Config
{

    internal class PaqueteConfig : IEntityTypeConfiguration<Paquete>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Paquete> builder)
        {
            builder.ToTable("paquete");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("paqueteId");
            builder.Property(x => x.Name)
                .HasColumnName("paqueteName");


        }
    }
}
