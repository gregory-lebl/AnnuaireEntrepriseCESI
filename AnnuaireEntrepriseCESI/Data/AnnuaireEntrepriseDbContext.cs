using AnnuaireEntrepriseCESI.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace AnnuaireEntrepriseCESI.Data
{
    public class AnnuaireEntrepriseDbContext : DbContext
    {

        #region Constructor
        public AnnuaireEntrepriseDbContext() : base()
        {

        }
        #endregion


        #region DbSet
        public DbSet<Employe> Employe { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Site> Site { get; set; }
        #endregion

        #region DatabaseConfiguration
        // Définir la configuration de la base de données
        public static string GetConnectionString()
        {
            return "Server=(localdb)\\MSSQLLocalDB;Database=AnnuaireEntreprise;Trusted_Connection=True;MultipleActiveResultSets=true";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var _connectionString = GetConnectionString();

                optionsBuilder.UseSqlServer(_connectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }
        #endregion
        #region Seeder
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var sites = SeedSite();
            modelBuilder.Entity<Site>().HasData(sites);
        }

        private static List<Site> SeedSite()
        {
            return new List<Site>
            {
                new Site("Paris","Site administratif"),
                new Site("Nantes","Site de Production"),
                new Site("Toulouse","Site de Production"),
                new Site("Nice","Site de Production"),
                new Site("Lille","Site de Production"),
            };
        }

        #endregion

    }
}
