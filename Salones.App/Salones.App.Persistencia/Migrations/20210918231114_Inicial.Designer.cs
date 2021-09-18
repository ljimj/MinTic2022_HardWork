﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Salones.App.Persistencia;

namespace Salones.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210918231114_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Salones.App.Dominio.Covid", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("estadoCovid")
                        .HasColumnType("int");

                    b.Property<string>("fechaDiagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("periodoAislamiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sintomas")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("DiagnosticosCovid");
                });

            modelBuilder.Entity("Salones.App.Dominio.Ingreso", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FechaIngreso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("personaid")
                        .HasColumnType("int");

                    b.Property<int?>("salonid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("personaid");

                    b.HasIndex("salonid");

                    b.ToTable("IngresosSalon");
                });

            modelBuilder.Entity("Salones.App.Dominio.Persona", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Sedeid")
                        .HasColumnType("int");

                    b.Property<string>("apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<int?>("estadoCovidid")
                        .HasColumnType("int");

                    b.Property<string>("identificación")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tipoIdentificacion")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Sedeid");

                    b.HasIndex("estadoCovidid");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Salones.App.Dominio.Salon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Sedeid")
                        .HasColumnType("int");

                    b.Property<int>("capacidad")
                        .HasColumnType("int");

                    b.Property<bool>("disponibilidad")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("Sedeid");

                    b.ToTable("Salones");
                });

            modelBuilder.Entity("Salones.App.Dominio.Sede", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("cantidadSalones")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Sedes");
                });

            modelBuilder.Entity("Salones.App.Dominio.Directivo", b =>
                {
                    b.HasBaseType("Salones.App.Dominio.Persona");

                    b.Property<string>("unidad")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Directivo");
                });

            modelBuilder.Entity("Salones.App.Dominio.Estudiante", b =>
                {
                    b.HasBaseType("Salones.App.Dominio.Persona");

                    b.Property<string>("carrera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("facultad")
                        .HasColumnType("int");

                    b.Property<string>("semestre")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Estudiante");
                });

            modelBuilder.Entity("Salones.App.Dominio.PersonalAseo", b =>
                {
                    b.HasBaseType("Salones.App.Dominio.Persona");

                    b.Property<string>("turno")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("PersonalAseo");
                });

            modelBuilder.Entity("Salones.App.Dominio.Profesor", b =>
                {
                    b.HasBaseType("Salones.App.Dominio.Persona");

                    b.Property<string>("departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("facultad")
                        .HasColumnType("int")
                        .HasColumnName("Profesor_facultad");

                    b.Property<string>("materia")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Profesor");
                });

            modelBuilder.Entity("Salones.App.Dominio.Ingreso", b =>
                {
                    b.HasOne("Salones.App.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaid");

                    b.HasOne("Salones.App.Dominio.Salon", "salon")
                        .WithMany()
                        .HasForeignKey("salonid");

                    b.Navigation("persona");

                    b.Navigation("salon");
                });

            modelBuilder.Entity("Salones.App.Dominio.Persona", b =>
                {
                    b.HasOne("Salones.App.Dominio.Sede", null)
                        .WithMany("personasAutorizadas")
                        .HasForeignKey("Sedeid");

                    b.HasOne("Salones.App.Dominio.Covid", "estadoCovid")
                        .WithMany()
                        .HasForeignKey("estadoCovidid");

                    b.Navigation("estadoCovid");
                });

            modelBuilder.Entity("Salones.App.Dominio.Salon", b =>
                {
                    b.HasOne("Salones.App.Dominio.Sede", null)
                        .WithMany("salones")
                        .HasForeignKey("Sedeid");
                });

            modelBuilder.Entity("Salones.App.Dominio.Sede", b =>
                {
                    b.Navigation("personasAutorizadas");

                    b.Navigation("salones");
                });
#pragma warning restore 612, 618
        }
    }
}
