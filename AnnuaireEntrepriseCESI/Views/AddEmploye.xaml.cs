using AnnuaireEntrepriseCESI.Data;
using AnnuaireEntrepriseCESI.Data.StorageModels;
using System;
using System.Linq;
using System.Windows;

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
            ServiceSelector.ItemsSource = context.Service.ToList();
            SiteSelector.ItemsSource = context.Site.ToList();
        }

        private void SubmitEmploye_Click(object sender, RoutedEventArgs e)
        {
            if (
                InputFirstName.Text != null &&
                InputLastName.Text != null &&
                InputCellPhoneNumber.Text != null &&
                InputFixePhoneNumber.Text != null &&
                InputEmail.Text != null &&
                ServiceSelector.SelectedValue.ToString() != null &&
                SiteSelector.SelectedValue.ToString() != null
            )
            {
                Service serviceSelector = (Service)ServiceSelector.SelectedItem;
                Guid serviceId = serviceSelector.Id;

                Site siteSelector = (Site)SiteSelector.SelectedValue;
                Guid siteId = siteSelector.Id;

                Employe addEmploye = new Employe(
                    InputFirstName.Text, 
                    InputLastName.Text, 
                    InputCellPhoneNumber.Text,
                    InputFixePhoneNumber.Text,
                    InputEmail.Text,
                    "Visiteur",
                    serviceId,
                    siteId);

                context.Employe.Add(addEmploye);
                context.SaveChanges();

                MessageBox.Show("Nouvel employé créé", "OK", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
