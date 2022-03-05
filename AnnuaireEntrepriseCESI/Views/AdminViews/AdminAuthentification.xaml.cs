using AnnuaireEntrepriseCESI.Data;
using AnnuaireEntrepriseCESI.Data.StorageModels;
using AnnuaireEntrepriseCESI.Views.AdminViews;
using System.Linq;
using System.Windows;

namespace AnnuaireEntrepriseCESI.Views
{
    /// <summary>
    /// Logique d'interaction pour AdminAuthentification.xaml
    /// </summary>
    public partial class AdminAuthentification : Window
    {
        private readonly AnnuaireEntrepriseDbContext context = new AnnuaireEntrepriseDbContext();
        public AdminAuthentification()
        {
            InitializeComponent();
        }

        private void AdminLoginBtn_Click(object sender, RoutedEventArgs e)
        {
            string password = AdminPassword.Password.ToString();
            Admin admin = context.Admin.Where(o => o.Password == password).Single();

            if (admin is Admin)
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                Close();
            }
        }
    }
}
