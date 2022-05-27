using AnnuaireEntrepriseCESI.Data;
using AnnuaireEntrepriseCESI.Data.StorageModels;
using AnnuaireEntrepriseCESI.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AnnuaireEntrepriseCESI.Views.AdminViews.AdminSite
{
    /// <summary>
    /// Logique d'interaction pour DeleteSite.xaml
    /// </summary>
    public partial class DeleteSite : Window
    {
        private readonly AnnuaireEntrepriseDbContext context = new AnnuaireEntrepriseDbContext();
        public DeleteSite()
        {
            InitializeComponent();
            FillDataGrid();
        }
        private void FillDataGrid()
        {
            List<Site> sites = context.Site.ToList();
            DataGridSite.ItemsSource = TransformStorageModelServiceToServiceViewModel(sites);
        }
        /// <summary>
        /// Fait la transition entre le model de stockage Site et le SiteViewModel
        /// </summary>
        /// <param name="employes"></param>
        /// <returns></returns>
        private List<SiteViewModel> TransformStorageModelServiceToServiceViewModel(List<Site> sites)
        {
            List<SiteViewModel> serviceViewModel = new List<SiteViewModel>();

            foreach (var site in sites)
            {
                SiteViewModel viewModel = new SiteViewModel(site);
                serviceViewModel.Add(viewModel);
            }

            return serviceViewModel;
        }

        private void DeleteSite_Click(object sender, RoutedEventArgs e)
        {
            var sender_context = sender as Button;
            SiteViewModel site = (SiteViewModel)sender_context!.DataContext;

            Site currentSite = context.Site.Where(o => o.Id == site.Id).FirstOrDefault();

            context.Site.Remove(currentSite);
            context.SaveChanges();

            MessageBox.Show("Site supprimé", "OK", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }
    }
}
