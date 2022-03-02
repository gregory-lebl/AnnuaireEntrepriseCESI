using AnnuaireEntrepriseCESI.Data.Models;
using Microsoft.EntityFrameworkCore;

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
        // Insérer des fausses données
        #endregion
    }
}
