using AnnuaireEntrepriseCESI.Data;
using AnnuaireEntrepriseCESI.Data.StorageModels;
using System;
using System.Linq;
using System.Windows;

namespace AnnuaireEntrepriseCESI.Views.AdminViews.AdminEmploye
{
    /// <summary>
    /// Logique d'interaction pour UpdateOneEmploye.xaml
    /// </summary>
    public partial class UpdateOneEmploye : Window
    {
        private readonly AnnuaireEntrepriseDbContext context = new AnnuaireEntrepriseDbContext();
        public UpdateOneEmploye(string lastname, string firstname, string cellPhone, string fixePhone, string email, Guid serviceId, Guid siteId)
        {
            InitializeComponent();

            Service service = GetEmployeService(serviceId);

            InputEmployeLastName.Text = lastname;
            InputEmployeFirstName.Text = firstname;
            InputEmployeCellPhoneNumber.Text = cellPhone;
            InputEmployeFixePhoneNumber.Text = fixePhone;
            InputEmployeEmail.Text = email;
            ComboBoxService.SelectedValue = service.Id;
            ComboBoxSite.SelectedValue = siteId;

            ComboBoxService.ItemsSource = context.Service.ToList();
            ComboBoxSite.ItemsSource = context.Site.ToList();
        }
        /// <summary>
        /// Récupère le service auquel l'employé est rattaché
        /// </summary>
        /// <param name="id"></param>
        private Service GetEmployeService(Guid id)
        {
            return context.Service.Where(o => o.Id == id).First();
        }

        private void BtnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            if (
                InputEmployeFirstName.Text != null &&
                InputEmployeLastName.Text != null &&
                InputEmployeCellPhoneNumber.Text != null &&
                InputEmployeFixePhoneNumber.Text != null &&
                InputEmployeEmail.Text != null &&
                ComboBoxService.SelectedValue.ToString() != null &&
                ComboBoxSite.SelectedValue.ToString() != null
            )
            {
                Service serviceSelector = (Service)ComboBoxService.SelectedItem;
                Guid serviceId = serviceSelector.Id;

                Site siteSelector = (Site)ComboBoxSite.SelectedValue;
                Guid siteId = siteSelector.Id;

                Employe employe = new Employe(
                    InputEmployeFirstName.Text,
                    InputEmployeLastName.Text,
                    InputEmployeCellPhoneNumber.Text,
                    InputEmployeFixePhoneNumber.Text,
                    InputEmployeEmail.Text,
                    "Visiteur",
                    serviceId,
                    siteId);
            }
        }
    }
}
