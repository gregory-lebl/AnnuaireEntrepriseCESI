using AnnuaireEntrepriseCESI.Data;
using AnnuaireEntrepriseCESI.Data.StorageModels;
using System.Windows;

namespace AnnuaireEntrepriseCESI.Views.AdminViews.AdminSite
{
    /// <summary>
    /// Logique d'interaction pour AddSite.xaml
    /// </summary>
    public partial class AddSite : Window
    {
        private readonly AnnuaireEntrepriseDbContext context = new AnnuaireEntrepriseDbContext();
        public AddSite()
        {
            InitializeComponent();
        }

        private void SaveSite_Click(object sender, RoutedEventArgs e)
        {
            string siteDesc = SiteDescription.Text;
            string siteName = SiteName.Text;

            Site NewSite = new Site(siteName,siteDesc);
            context.Site.Add(NewSite);

            int changes = context.SaveChanges();

            if (changes >= 1)
            {
                MessageBox.Show("Nouveau site créé", "OK", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erreur à la création du site.", "OK", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
