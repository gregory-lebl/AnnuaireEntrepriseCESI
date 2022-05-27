using AnnuaireEntrepriseCESI.Data;
using AnnuaireEntrepriseCESI.Data.StorageModels;
using System.Linq;
using System.Windows;

namespace AnnuaireEntrepriseCESI.Views.AdminViews.AdminService
{
    /// <summary>
    /// Logique d'interaction pour AddService.xaml
    /// </summary>
    public partial class AddService : Window
    {
        private readonly AnnuaireEntrepriseDbContext context = new AnnuaireEntrepriseDbContext();
        public AddService()
        {
            InitializeComponent();
            SiteSelector.ItemsSource = context.Site.ToList();
        }

        private void SaveService_Click(object sender, RoutedEventArgs e)
        {
            string serviceName = ServiceName.Text;
            Service newService = new Service(serviceName);

            context.Service.Add(newService);
            int changes = context.SaveChanges();

            if (changes >= 1)
            {
                MessageBox.Show("Nouveau service créé", "OK", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Erreur à la création du service.", "OK", MessageBoxButton.OK, MessageBoxImage.Error);
                Close();
            }
        }
    }
}
