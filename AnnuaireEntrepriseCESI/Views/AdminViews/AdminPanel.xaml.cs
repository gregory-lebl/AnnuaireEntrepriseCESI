using AnnuaireEntrepriseCESI.Views.AdminViews.AdminEmploye;
using AnnuaireEntrepriseCESI.Views.AdminViews.AdminService;
using System.Windows;

namespace AnnuaireEntrepriseCESI.Views.AdminViews
{
    /// <summary>
    /// Logique d'interaction pour AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AddEmployBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEmploye window = new AddEmploye();
            window.Show();
        }

        private void UpdateEmployeBtn_Click(object sender, RoutedEventArgs e)
        {
            UpdateEmploye window = new UpdateEmploye();
            window.Show();
        }

        private void DeleteEmployeBtn_Click(object sender, RoutedEventArgs e)
        {
            DeleteEmploye window = new DeleteEmploye();
            window.Show();
        }

        private void AddServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            AddService window = new AddService();
            window.Show();
        }

        private void DeleteServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            DeleteService window = new DeleteService();
            window.Show();
        }
    }
}
