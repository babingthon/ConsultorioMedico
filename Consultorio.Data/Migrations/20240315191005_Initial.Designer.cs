﻿// <auto-generated />
using System;
using Consultorio.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Consultorio.Infra.Data.Migrations
{
    [DbContext(typeof(ConsultorioDbContext))]
    [Migration("20240315191005_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Consultorio.Domain.Entity.Consult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("Convenio")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.Property<int>("IdService")
                        .HasColumnType("int");

                    b.Property<string>("IdentifiedGoogleCalendar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.HasIndex("IdService");

                    b.ToTable("Consults");
                });

            modelBuilder.Entity("Consultorio.Domain.Entity.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BloodType")
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("IdSpecialty")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RegisterCRM")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdSpecialty");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Rua dos Bobos, Nº 0",
                            BirthDate = new DateTime(1997, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodType = 4,
                            CPF = "06445663225",
                            Email = "AntonioCaudas@email.com",
                            IdSpecialty = 1,
                            LastName = "Pereira Caudas",
                            Name = "Antônio Pereira Caudas",
                            PhoneNumber = "86995287928",
                            RegisterCRM = "12345/PI"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Av. Brasil, Nº 100",
                            BirthDate = new DateTime(1985, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodType = 7,
                            CPF = "09876543210",
                            Email = "joao.silva@email.com",
                            IdSpecialty = 2,
                            LastName = "da Silva",
                            Name = "João da Silva",
                            PhoneNumber = "86995554433",
                            RegisterCRM = "54321/PI"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Rua das Flores, Nº 50",
                            BirthDate = new DateTime(1976, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodType = 5,
                            CPF = "11223344556",
                            Email = "maria.oliveira@email.com",
                            IdSpecialty = 2,
                            LastName = "Oliveira",
                            Name = "Maria Oliveira",
                            PhoneNumber = "869944332211",
                            RegisterCRM = "67890/PI"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Av. Principal, Nº 300",
                            BirthDate = new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodType = 6,
                            CPF = "55443322111",
                            Email = "carlos.souza@email.com",
                            IdSpecialty = 4,
                            LastName = "Souza",
                            Name = "Carlos Souza",
                            PhoneNumber = "869966998877",
                            RegisterCRM = "13579/PI"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Rua da Paz, Nº 15",
                            BirthDate = new DateTime(1983, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodType = 5,
                            CPF = "33445566778",
                            Email = "ana.santos@email.com",
                            IdSpecialty = 5,
                            LastName = "Santos",
                            Name = "Ana Santos",
                            PhoneNumber = "869977776655",
                            RegisterCRM = "24680/PI"
                        },
                        new
                        {
                            Id = 6,
                            Address = "Av. Central, Nº 200",
                            BirthDate = new DateTime(1988, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodType = 2,
                            CPF = "99887766554",
                            Email = "pedro.moraes@email.com",
                            IdSpecialty = 6,
                            LastName = "Moraes",
                            Name = "Pedro Moraes",
                            PhoneNumber = "869988887766",
                            RegisterCRM = "97531/PI"
                        },
                        new
                        {
                            Id = 7,
                            Address = "Rua das Árvores, Nº 30",
                            BirthDate = new DateTime(1980, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodType = 5,
                            CPF = "22113344556",
                            Email = "fernanda.costa@email.com",
                            IdSpecialty = 7,
                            LastName = "Costa",
                            Name = "Fernanda Costa",
                            PhoneNumber = "869933377755",
                            RegisterCRM = "86420/PI"
                        },
                        new
                        {
                            Id = 8,
                            Address = "Av. das Estrelas, Nº 75",
                            BirthDate = new DateTime(1995, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodType = 4,
                            CPF = "77889900123",
                            Email = "rafaela.lima@email.com",
                            IdSpecialty = 8,
                            LastName = "Lima",
                            Name = "Rafaela Lima",
                            PhoneNumber = "869922223344",
                            RegisterCRM = "54321/PI"
                        });
                });

            modelBuilder.Entity("Consultorio.Domain.Entity.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BloodType")
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double?>("Height")
                        .HasColumnType("float");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Rua das Flores, Nº 10",
                            BirthDate = new DateTime(1990, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodType = 4,
                            CPF = "12345678901",
                            Email = "maria.silva@email.com",
                            Height = 1.3600000000000001,
                            LastName = "da Silva",
                            Name = "Maria da Silva",
                            PhoneNumber = "869988776655",
                            Weight = 70.0
                        },
                        new
                        {
                            Id = 2,
                            Address = "Av. Central, Nº 50",
                            BirthDate = new DateTime(1985, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodType = 3,
                            CPF = "23456789012",
                            Email = "jose.santos@email.com",
                            Height = 1.8,
                            LastName = "Santos",
                            Name = "José Santos",
                            PhoneNumber = "869977665544",
                            Weight = 85.0
                        },
                        new
                        {
                            Id = 3,
                            Address = "Rua dos Pássaros, Nº 25",
                            BirthDate = new DateTime(1993, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodType = 5,
                            CPF = "34567890123",
                            Email = "ana.souza@email.com",
                            Height = 1.6499999999999999,
                            LastName = "Souza",
                            Name = "Ana Souza",
                            PhoneNumber = "869966554433",
                            Weight = 60.0
                        },
                        new
                        {
                            Id = 4,
                            Address = "Av. Brasil, Nº 100",
                            BirthDate = new DateTime(1980, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodType = 6,
                            CPF = "45678901234",
                            Email = "carlos.oliveira@email.com",
                            Height = 1.7,
                            LastName = "Oliveira",
                            Name = "Carlos Oliveira",
                            PhoneNumber = "869955443322",
                            Weight = 75.0
                        },
                        new
                        {
                            Id = 5,
                            Address = "Rua Principal, Nº 300",
                            BirthDate = new DateTime(1975, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodType = 4,
                            CPF = "56789012345",
                            Email = "mariana.costa@email.com",
                            Height = 1.6000000000000001,
                            LastName = "Costa",
                            Name = "Mariana Costa",
                            PhoneNumber = "869944332211",
                            Weight = 65.0
                        },
                        new
                        {
                            Id = 6,
                            Address = "Av. das Árvores, Nº 15",
                            BirthDate = new DateTime(1992, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodType = 5,
                            CPF = "67890123456",
                            Email = "rafael.oliveira@email.com",
                            Height = 1.8500000000000001,
                            LastName = "Oliveira",
                            Name = "Rafael Oliveira",
                            PhoneNumber = "869933221100",
                            Weight = 80.0
                        },
                        new
                        {
                            Id = 7,
                            Address = "Rua do Sol, Nº 200",
                            BirthDate = new DateTime(1987, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodType = 2,
                            CPF = "78901234567",
                            Email = "juliana.lima@email.com",
                            Height = 1.75,
                            LastName = "Lima",
                            Name = "Juliana Lima",
                            PhoneNumber = "869922110011",
                            Weight = 70.0
                        },
                        new
                        {
                            Id = 8,
                            Address = "Av. das Estrelas, Nº 75",
                            BirthDate = new DateTime(1996, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodType = 5,
                            CPF = "89012345678",
                            Email = "fernando.santos@email.com",
                            Height = 1.8,
                            LastName = "Santos",
                            Name = "Fernando Santos",
                            PhoneNumber = "869911001122",
                            Weight = 85.0
                        });
                });

            modelBuilder.Entity("Consultorio.Domain.Entity.ServiceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Consultorio.Domain.Entity.Specialty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("MedicalSpecialty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Specialty");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MedicalSpecialty = "Clínico Geral"
                        },
                        new
                        {
                            Id = 2,
                            MedicalSpecialty = "Cardiologia"
                        },
                        new
                        {
                            Id = 3,
                            MedicalSpecialty = "Pediatria"
                        },
                        new
                        {
                            Id = 4,
                            MedicalSpecialty = "Ortopedia"
                        },
                        new
                        {
                            Id = 5,
                            MedicalSpecialty = "Dermatologia"
                        },
                        new
                        {
                            Id = 6,
                            MedicalSpecialty = "Oftalmologia"
                        },
                        new
                        {
                            Id = 7,
                            MedicalSpecialty = "Psiquiatria"
                        },
                        new
                        {
                            Id = 8,
                            MedicalSpecialty = "Ginecologia"
                        },
                        new
                        {
                            Id = 9,
                            MedicalSpecialty = "Urologia"
                        },
                        new
                        {
                            Id = 10,
                            MedicalSpecialty = "Neurologia"
                        });
                });

            modelBuilder.Entity("Consultorio.Domain.Entity.Consult", b =>
                {
                    b.HasOne("Consultorio.Domain.Entity.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("IdDoctor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Consultorio.Domain.Entity.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("IdPatient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Consultorio.Domain.Entity.ServiceEntity", "Service")
                        .WithMany()
                        .HasForeignKey("IdService")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Consultorio.Domain.Entity.Doctor", b =>
                {
                    b.HasOne("Consultorio.Domain.Entity.Specialty", "Specialty")
                        .WithMany()
                        .HasForeignKey("IdSpecialty")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialty");
                });
#pragma warning restore 612, 618
        }
    }
}
