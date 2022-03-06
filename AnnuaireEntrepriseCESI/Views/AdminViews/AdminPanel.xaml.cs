using AnnuaireEntrepriseCESI.Views.AdminViews.AdminEmploye;
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
        /*
        private void DeleteEmployeBtn_Click(object sender, RoutedEventArgs e)
        {
            DeleteEmploye window = new DeleteEmploye();
            window.Show();
        }
        */
    }
}
