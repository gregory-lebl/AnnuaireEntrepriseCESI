using AnnuaireEntrepriseCESI.Data;
using AnnuaireEntrepriseCESI.Data.StorageModels;
using AnnuaireEntrepriseCESI.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AnnuaireEntrepriseCESI.Views.AdminViews.AdminService
{
    /// <summary>
    /// Logique d'interaction pour DeleteService.xaml
    /// </summary>
    public partial class DeleteService : Window
    {
        private readonly AnnuaireEntrepriseDbContext context = new AnnuaireEntrepriseDbContext();
        public DeleteService()
        {
            InitializeComponent();
            FillDataGrid();
        }
        private void FillDataGrid()
        {
            List<Service> services = context.Service.ToList();
            DataGridService.ItemsSource = TransformStorageModelServiceToServiceViewModel(services);
        }
        /// <summary>
        /// Fait la transition entre le model de stockage Service et le ServiceViewModel
        /// </summary>
        /// <param name="employes"></param>
        /// <returns></returns>
        private List<ServiceViewModel> TransformStorageModelServiceToServiceViewModel(List<Service> services)
        {
            List<ServiceViewModel> serviceViewModel = new List<ServiceViewModel>();

            foreach (var service in services)
            {
                ServiceViewModel viewModel = new ServiceViewModel(service.Id, service.Name);
                serviceViewModel.Add(viewModel);
            }

            return serviceViewModel;
        }

        private void DeleteService_Click(object sender, RoutedEventArgs e)
        {
            var sender_context = sender as Button;
            ServiceViewModel service = (ServiceViewModel)sender_context!.DataContext;

            Service currentService = context.Service.Where(o => o.Id == service.Id).FirstOrDefault();

            context.Service.Remove(currentService);
            context.SaveChanges();

            MessageBox.Show("Service supprimé", "OK", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
        }
    }
}
