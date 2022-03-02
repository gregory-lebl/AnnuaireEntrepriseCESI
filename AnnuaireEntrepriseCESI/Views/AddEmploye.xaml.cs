using AnnuaireEntrepriseCESI.Data;
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
using System.Windows.Shapes;

namespace AnnuaireEntrepriseCESI.Views
{
    /// <summary>
    /// Logique d'interaction pour AddEmploye.xaml
    /// </summary>
    public partial class AddEmploye : Window
    {

        private readonly AnnuaireEntrepriseDbContext context = new AnnuaireEntrepriseDbContext();
        public AddEmploye()
        {
            InitializeComponent();
            BindingServices();
            BindingSite();
        }
        /// <summary>
        /// Permet d'afficher un sélecteur avec l'ensemble des Services
        /// </summary>
        public void BindingServices()
        {
            if (context.Database.EnsureCreated())
            {
                ServiceSelector.ItemsSource = context.Service.ToList();
            }
        }
        /// <summary>
        /// Permet d'afficher un sélecteur avec l'ensemble des Services
        /// </summary>
        public void BindingSite()
        {
            if (context.Database.EnsureCreated())
            {
                SiteSelector.ItemsSource = context.Site.ToList();
            }
        }

        private void SubmitEmploye_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
