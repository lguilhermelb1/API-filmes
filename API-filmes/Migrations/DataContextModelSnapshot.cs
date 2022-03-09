﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("API.Models.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Classificacao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Descricao")
                        .HasMaxLength(160)
                        .HasColumnType("varchar(160)");

                    b.Property<int?>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.HasIndex("GeneroId");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("API.Models.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("API.Models.Filme", b =>
                {
                    b.HasOne("API.Models.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroId");

                    b.Navigation("Genero");
                });
#pragma warning restore 612, 618
        }
    }
}
