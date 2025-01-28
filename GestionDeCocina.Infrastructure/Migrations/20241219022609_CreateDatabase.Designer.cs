﻿// <auto-generated />
using System;
using GestionDeCocina.Infrastructure.StoredModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestionDeCocina.Infrastructure.Migrations
{
    [DbContext(typeof(StoredDbContext))]
    [Migration("20241219022609_CreateDatabase")]
    partial class CreateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("GestionDeCocina.Infrastructure.StoredModel.Entities.IngredienteStoredModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("ingredienteId");

                    b.Property<string>("IngredienteName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ingredienteName");

                    b.HasKey("Id");

                    b.ToTable("ingrediente");
                });

            modelBuilder.Entity("GestionDeCocina.Infrastructure.StoredModel.Entities.PaqueteAndRecetaStoredModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("paqueteAndRecetaId");

                    b.Property<Guid>("paquete")
                        .HasColumnType("char(36)")
                        .HasColumnName("paqueteId");

                    b.Property<Guid>("receta")
                        .HasColumnType("char(36)")
                        .HasColumnName("recetaId");

                    b.HasKey("Id");

                    b.ToTable("paqueteAndReceta");
                });

            modelBuilder.Entity("GestionDeCocina.Infrastructure.StoredModel.Entities.PaqueteStoredModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("paqueteId");

                    b.Property<string>("Paquetename")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("paqueteName");

                    b.HasKey("Id");

                    b.ToTable("paquete");
                });

            modelBuilder.Entity("GestionDeCocina.Infrastructure.StoredModel.Entities.RecetaStoredModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("recetaId");

                    b.Property<string>("recetaName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("recetaName");

                    b.HasKey("Id");

                    b.ToTable("receta");
                });

            modelBuilder.Entity("GestionDeCocina.Infrastructure.StoredModel.Entities.recetaAndIngrediente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("recetaAndIngredienteId");

                    b.Property<Guid>("ingrediente")
                        .HasColumnType("char(36)")
                        .HasColumnName("ingredienteId");

                    b.Property<Guid>("receta")
                        .HasColumnType("char(36)")
                        .HasColumnName("recetaId");

                    b.HasKey("Id");

                    b.ToTable("recetaAndIngrediente");
                });
#pragma warning restore 612, 618
        }
    }
}
