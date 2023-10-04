﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using citas_medicas.Repositories;

#nullable disable

namespace citasMedicas_net7.Migrations
{
    [DbContext(typeof(CMContext))]
    [Migration("20231004104320_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MedicoPaciente", b =>
                {
                    b.Property<long>("MedicosId")
                        .HasColumnType("bigint");

                    b.Property<long>("PacientesId")
                        .HasColumnType("bigint");

                    b.HasKey("MedicosId", "PacientesId");

                    b.HasIndex("PacientesId");

                    b.ToTable("MedicoPaciente");
                });

            modelBuilder.Entity("citas_medicas.Entities.Cita", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("DiagnosticoId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<long?>("MedicoId")
                        .HasColumnType("bigint");

                    b.Property<string>("MotivoCita")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PacienteId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DiagnosticoId");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PacienteId");

                    b.ToTable("CITAS", (string)null);
                });

            modelBuilder.Entity("citas_medicas.Entities.Diagnostico", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Enfermedad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValoracionEspecialista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DIAGNOSTICOS", (string)null);
                });

            modelBuilder.Entity("citas_medicas.Entities.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("USUARIOS", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("citas_medicas.Entities.Medico", b =>
                {
                    b.HasBaseType("citas_medicas.Entities.Usuario");

                    b.Property<string>("NumColegiado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("MEDICOS", (string)null);
                });

            modelBuilder.Entity("citas_medicas.Entities.Paciente", b =>
                {
                    b.HasBaseType("citas_medicas.Entities.Usuario");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NSS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumTarjeta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("PACIENTES", (string)null);
                });

            modelBuilder.Entity("MedicoPaciente", b =>
                {
                    b.HasOne("citas_medicas.Entities.Medico", null)
                        .WithMany()
                        .HasForeignKey("MedicosId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("citas_medicas.Entities.Paciente", null)
                        .WithMany()
                        .HasForeignKey("PacientesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("citas_medicas.Entities.Cita", b =>
                {
                    b.HasOne("citas_medicas.Entities.Diagnostico", "Diagnostico")
                        .WithMany()
                        .HasForeignKey("DiagnosticoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("citas_medicas.Entities.Medico", null)
                        .WithMany("Citas")
                        .HasForeignKey("MedicoId");

                    b.HasOne("citas_medicas.Entities.Paciente", null)
                        .WithMany("Citas")
                        .HasForeignKey("PacienteId");

                    b.Navigation("Diagnostico");
                });

            modelBuilder.Entity("citas_medicas.Entities.Medico", b =>
                {
                    b.HasOne("citas_medicas.Entities.Usuario", null)
                        .WithOne()
                        .HasForeignKey("citas_medicas.Entities.Medico", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("citas_medicas.Entities.Paciente", b =>
                {
                    b.HasOne("citas_medicas.Entities.Usuario", null)
                        .WithOne()
                        .HasForeignKey("citas_medicas.Entities.Paciente", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("citas_medicas.Entities.Medico", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("citas_medicas.Entities.Paciente", b =>
                {
                    b.Navigation("Citas");
                });
#pragma warning restore 612, 618
        }
    }
}
