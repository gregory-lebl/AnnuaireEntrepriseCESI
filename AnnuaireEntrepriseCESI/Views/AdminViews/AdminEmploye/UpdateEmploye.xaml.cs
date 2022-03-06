using AnnuaireEntrepriseCESI.Data;
using AnnuaireEntrepriseCESI.Data.StorageModels;
using AnnuaireEntrepriseCESI.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AnnuaireEntrepriseCESI.Views.AdminViews.AdminEmploye
{
    /// <summary>
    /// Logique d'interaction pour UpdateEmploye.xaml
    /// </summary>
    public partial class UpdateEmploye : Window
    {
        private readonly AnnuaireEntrepriseDbContext context = new AnnuaireEntrepriseDbContext();
        public UpdateEmploye()
        {
            InitializeComponent();
            SearchEmployeService.ItemsSource = context.Service.ToList();
            SearchEmployeSite.ItemsSource = context.Site.ToList();
        }

        /// <summary>
        /// Fait la transition entre le model de stockage Employe et le EmployeViewModel
        /// </summary>
        /// <param name="employes"></param>
        /// <returns></returns>
        private List<EmployeViewModel> TransformStorageModelEmployeToEmployeViewModel(List<Employe> employes)
        {
            List<EmployeViewModel> employesViewModel = new List<EmployeViewModel>();

            foreach (var employe in employes)
            {
                Site site = context.Site.Where(o => o.Id == employe.SiteId).First();
                Service service = context.Service.Where(o => o.Id == employe.ServiceId).First();

                EmployeViewModel viewModel = new EmployeViewModel(
                    employe.Id,
                    employe.FirstName,
                    employe.LastName,
                    employe.CellPhoneNumber,
                    employe.FixePhoneNumber,
                    employe.Email,
                    employe.Role,
                    service.Name,
                    site.Name);
                employesViewModel.Add(viewModel);
            }

            return employesViewModel;
        }

        private void SearchEmployeBtn_Click(object sender, RoutedEventArgs e)
        {
            List<EmployeViewModel> viewModel = new List<EmployeViewModel>();

            if (!string.IsNullOrEmpty(SearchEmployeName.Text))
            {
                string Name = SearchEmployeName.Text;
                List<Employe> employes = context.Employe.Where(o => o.LastName == Name).ToList();

                viewModel = TransformStorageModelEmployeToEmployeViewModel(employes);
            }
            else
            {
                if (SearchEmployeService.SelectedValue is Service)
                {
                    Service serviceSelector = (Service)SearchEmployeService.SelectedItem;
                    Guid serviceId = serviceSelector.Id;
                    List<Employe> employes = context.Employe.Where(o => o.ServiceId == serviceId).ToList();

                    viewModel = TransformStorageModelEmployeToEmployeViewModel(employes);
                }
                else
                {
                    if (SearchEmployeSite.SelectedValue is Site)
                    {
                        Site siteSelector = (Site)SearchEmployeSite.SelectedValue;
                        Guid siteId = siteSelector.Id;
                        List<Employe> employes = context.Employe.Where(o => o.SiteId == siteId).ToList();

                        viewModel = TransformStorageModelEmployeToEmployeViewModel(employes);
                    }
                }
            }

            DataGridEmploye.ItemsSource = viewModel;
        }

        private void BtnUpdateEmploye_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }


}
