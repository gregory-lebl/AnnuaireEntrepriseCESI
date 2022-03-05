using AnnuaireEntrepriseCESI.Data;
using AnnuaireEntrepriseCESI.Data.Models;
using AnnuaireEntrepriseCESI.Data.ViewModels;
using AnnuaireEntrepriseCESI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnnuaireEntrepriseCESI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly AnnuaireEntrepriseDbContext context = new AnnuaireEntrepriseDbContext();

        public MainWindow()
        {
            InitializeComponent();
            FillDataGrid();
        }
        /// <summary>
        /// Rempli la DataGrid avec la liste des employés
        /// </summary>
        private void FillDataGrid()
        {
            List<Employe> employes = context.Employe.ToList();
            List<EmployeViewModel> employesViewModel = new List<EmployeViewModel>();

            foreach (var employe in employes)
            {
                Site site = (Site)context.Site.Where(o => o.Id == employe.SiteId).First();
                Service service = (Service)context.Service.Where(o => o.Id == employe.ServiceId).First();

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

            DataGrid.ItemsSource = employesViewModel;

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
    }
}
