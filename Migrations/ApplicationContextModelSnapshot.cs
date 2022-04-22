﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using iniciativa.Data;

#nullable disable

namespace iniciativa.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("iniciativa.Models.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("Date");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<int?>("iniciativaWomanid")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("iniciativaWomanid");

                    b.ToTable("Evento", (string)null);
                });

            modelBuilder.Entity("iniciativa.Models.IniciativaWoman", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(512)");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("id");

                    b.ToTable("IniciativaWoman", (string)null);
                });

            modelBuilder.Entity("iniciativa.Models.Evento", b =>
                {
                    b.HasOne("iniciativa.Models.IniciativaWoman", "iniciativaWoman")
                        .WithMany("Eventos")
                        .HasForeignKey("iniciativaWomanid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("iniciativaWoman");
                });

            modelBuilder.Entity("iniciativa.Models.IniciativaWoman", b =>
                {
                    b.Navigation("Eventos");
                });
#pragma warning restore 612, 618
        }
    }
}
