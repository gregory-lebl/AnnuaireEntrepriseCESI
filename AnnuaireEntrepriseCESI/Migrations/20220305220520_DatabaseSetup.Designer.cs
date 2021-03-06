// <auto-generated />
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
    [Migration("20220305220520_DatabaseSetup")]
    partial class DatabaseSetup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AnnuaireEntrepriseCESI.Data.StorageModels.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admin");

                    b.HasData(
                        new
                        {
                            Id = new Guid("45051e65-b01e-4bad-86ac-3faacae2f169"),
                            Email = "admin@admin.fr",
                            Password = "admin"
                        });
                });

            modelBuilder.Entity("AnnuaireEntrepriseCESI.Data.StorageModels.Employe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CellPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FixePhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SiteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Employe");
                });

            modelBuilder.Entity("AnnuaireEntrepriseCESI.Data.StorageModels.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Service");

                    b.HasData(
                        new
                        {
                            Id = new Guid("58b4fe53-07e6-4aca-88d0-397c53437b8f"),
                            Name = "Service Commercial"
                        },
                        new
                        {
                            Id = new Guid("8b1a0e4e-f717-4cb2-800c-754898c46613"),
                            Name = "Service Marketing"
                        },
                        new
                        {
                            Id = new Guid("4d7e2128-d65e-4779-8e11-5732bfda5360"),
                            Name = "Service Financier"
                        },
                        new
                        {
                            Id = new Guid("7ea5908a-d46f-4ea3-9d3e-0d9f91ade42f"),
                            Name = "Service Industriel"
                        },
                        new
                        {
                            Id = new Guid("342b1f79-7c1c-4013-bf3c-e522cc79127f"),
                            Name = "Service Ressources Humaines"
                        },
                        new
                        {
                            Id = new Guid("9ea93130-81f2-499f-81c0-eb72223ae60d"),
                            Name = "Service Achat"
                        },
                        new
                        {
                            Id = new Guid("1da8e146-9766-4c2b-89cf-0a6829d39d65"),
                            Name = "Service Juridique"
                        });
                });

            modelBuilder.Entity("AnnuaireEntrepriseCESI.Data.StorageModels.Site", b =>
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
                            Id = new Guid("eb83b75f-1718-4b8b-9349-59d842193d4e"),
                            Description = "Site administratif",
                            Name = "Paris"
                        },
                        new
                        {
                            Id = new Guid("80985050-0606-4ea9-b4ff-4655084595d8"),
                            Description = "Site de Production",
                            Name = "Nantes"
                        },
                        new
                        {
                            Id = new Guid("56aabeb2-5dd1-45e6-ba18-f5288d19a5ed"),
                            Description = "Site de Production",
                            Name = "Toulouse"
                        },
                        new
                        {
                            Id = new Guid("83033ef1-6f0e-4349-aa03-a1f03df04f2f"),
                            Description = "Site de Production",
                            Name = "Nice"
                        },
                        new
                        {
                            Id = new Guid("1498df82-8668-4c10-92dc-2f3010fefe5e"),
                            Description = "Site de Production",
                            Name = "Lille"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
