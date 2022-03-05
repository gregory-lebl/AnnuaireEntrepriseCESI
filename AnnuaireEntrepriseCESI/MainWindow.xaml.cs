using AnnuaireEntrepriseCESI.Data;
using AnnuaireEntrepriseCESI.Data.StorageModels;
using AnnuaireEntrepriseCESI.Data.ViewModels;
using AnnuaireEntrepriseCESI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AnnuaireEntrepriseCESI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly AnnuaireEntrepriseDbContext context = new AnnuaireEntrepriseDbContext();
        public bool connectedAsAdmin = true;

        public MainWindow()
        {
            InitializeComponent();
            FillDataGrid();
            SearchSelectorService.ItemsSource = context.Service.ToList();
            SearchSelectorSite.ItemsSource = context.Site.ToList();

            if (connectedAsAdmin == true)
            {

                EnableAdminBtn();
            }
            else
            {
                DisabledAdminBtn();
            }
        }

        private void AdminLogin(object sender, KeyEventArgs e)
        {

            if(e.Key == Key.F11)
            {
                var window = new AdminAuthentification();
                window.Show();
            }
        }

        private void EnableAdminBtn()
        {
            AddEmployBtn.Visibility = Visibility.Visible;
            UpdateEmployeBtn.Visibility = Visibility.Visible;
            DeleteEmployeBtn.Visibility = Visibility.Visible;

            AddServiceBtn.Visibility = Visibility.Visible;
            UpdateServiceBtn.Visibility = Visibility.Visible;
            DeleteServiceBtn.Visibility = Visibility.Visible;

            AddSiteBtn.Visibility = Visibility.Visible;
            UpdateSiteBtn.Visibility = Visibility.Visible;
            DeleteSiteBtn.Visibility = Visibility.Visible;
        }
        private void DisabledAdminBtn()
        {
            AddEmployBtn.Visibility = Visibility.Hidden;
            UpdateEmployeBtn.Visibility = Visibility.Hidden;
            DeleteEmployeBtn.Visibility = Visibility.Hidden;

            AddServiceBtn.Visibility = Visibility.Hidden;
            UpdateServiceBtn.Visibility = Visibility.Hidden;
            DeleteServiceBtn.Visibility = Visibility.Hidden;

            AddSiteBtn.Visibility = Visibility.Hidden;
            UpdateSiteBtn.Visibility = Visibility.Hidden;
            DeleteSiteBtn.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Rempli la DataGrid avec la liste des employés
        /// </summary>
        private void FillDataGrid()
        {
            List<Employe> employes = context.Employe.ToList();

            DataGrid.ItemsSource = TransformStorageModelEmployeToEmployeViewModel(employes);

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
        private void BtnSearchEmploye_Click(object sender, RoutedEventArgs e)
        {
            List<EmployeViewModel> viewModel = new List<EmployeViewModel>();

            if (!string.IsNullOrEmpty(InputSearchEmploye.Text))
            {
                string Name = InputSearchEmploye.Text;
                List<Employe> employes = context.Employe.Where(o => o.LastName == Name).ToList();

                viewModel = TransformStorageModelEmployeToEmployeViewModel(employes);
            }
            else
            {
                if (SearchSelectorService.SelectedValue is Service)
                {
                    Service serviceSelector = (Service)SearchSelectorService.SelectedItem;
                    Guid serviceId = serviceSelector.Id;
                    List<Employe> employes = context.Employe.Where(o => o.ServiceId == serviceId).ToList();

                    viewModel = TransformStorageModelEmployeToEmployeViewModel(employes);
                }
                else
                {
                    if (SearchSelectorSite.SelectedValue is Site)
                    {
                        Site siteSelector = (Site)SearchSelectorSite.SelectedValue;
                        Guid siteId = siteSelector.Id;
                        List<Employe> employes = context.Employe.Where(o => o.SiteId == siteId).ToList();

                        viewModel = TransformStorageModelEmployeToEmployeViewModel(employes);
                    }
                }
            }

            DataGrid.ItemsSource = viewModel;
        }

        private void AddEmployBtn_Click(object sender, RoutedEventArgs e)
        {
            var window = new AddEmploye();
            window.Show();
        }

        private void UpdateEmploye_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteEmploye_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RefreshEmployesDataGrid_Click(object sender, RoutedEventArgs e)
        {
            FillDataGrid();
        }

        private void ResetSearchFilter()
        {
            SearchSelectorService.ItemsSource = null;
            SearchSelectorSite.ItemsSource = null;

            SearchSelectorService.Items.Clear();
            SearchSelectorSite.Items.Clear();

            SearchSelectorService.ItemsSource = context.Service.ToList();
            SearchSelectorSite.ItemsSource = context.Site.ToList();

            InputSearchEmploye.Clear();
        }

        private void BtnResetSearch_Click(object sender, RoutedEventArgs e)
        {
            ResetSearchFilter();
            FillDataGrid();
        }
    }
}
