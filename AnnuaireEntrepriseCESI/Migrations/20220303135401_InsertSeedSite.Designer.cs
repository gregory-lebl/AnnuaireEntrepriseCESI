﻿// <auto-generated />
using System;
using AnnuaireEntrepriseCESI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnnuaireEntrepriseCESI.Migrations
{
    [DbContext(typeof(AnnuaireEntrepriseDbContext))]
    [Migration("20220303135401_InsertSeedSite")]
    partial class InsertSeedSite
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AnnuaireEntrepriseCESI.Data.Models.Employe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CellPhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FixePhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SiteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Employe");
                });

            modelBuilder.Entity("AnnuaireEntrepriseCESI.Data.Models.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("AnnuaireEntrepriseCESI.Data.Models.Site", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Site");

                    b.HasData(
                        new
                        {
                            Id = new Guid("92ae7b85-091a-499a-b027-116f3c739461"),
                            Description = "Site administratif",
                            Name = "Paris"
                        },
                        new
                        {
                            Id = new Guid("9cc96c9e-7d27-4719-a3da-a41f04842ecc"),
                            Description = "Site de Production",
                            Name = "Nantes"
                        },
                        new
                        {
                            Id = new Guid("06de45a2-14a3-4c1b-b33e-e4162dbf8e6d"),
                            Description = "Site de Production",
                            Name = "Toulouse"
                        },
                        new
                        {
                            Id = new Guid("e2c484b7-6ca4-49a9-8c78-50e4905a0fe8"),
                            Description = "Site de Production",
                            Name = "Nice"
                        },
                        new
                        {
                            Id = new Guid("81e80e09-2e22-4ef0-b783-1b4e5de68de6"),
                            Description = "Site de Production",
                            Name = "Lille"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
