using AnnuaireEntrepriseCESI.Data.StorageModels;
using Microsoft.EntityFrameworkCore;
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

            var services = SeedService();
            modelBuilder.Entity<Service>().HasData(services);
        }

        /// <summary>
        /// Génère la liste des différents Sites
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Génère la liste des différents service de l'entreprise
        /// </summary>
        /// <returns></returns>
        private static List<Service> SeedService()
        {
            return new List<Service>
            {
                new Service("Service Commercial"),
                new Service("Service Marketing"),
                new Service("Service Financier"),
                new Service("Service Industriel"),
                new Service("Service Ressources Humaines"),
                new Service("Service Achat"),
                new Service("Service Juridique")
            };
        }

        #endregion

    }
}
