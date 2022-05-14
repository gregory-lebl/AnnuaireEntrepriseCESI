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
        public UpdateOneEmploye(Guid id, string lastname, string firstname, string cellPhone, string fixePhone, string email, Guid serviceId, Guid siteId)
        {
            InitializeComponent();

            ComboBoxService.ItemsSource = context.Service.ToList();
            ComboBoxSite.ItemsSource = context.Site.ToList();

            Service service = GetEmployeService(serviceId);
            Site site = GetEmployeSite(siteId);

            TextBlockEmployeId.Visibility = Visibility.Hidden;
            TextBlockEmployeId.Text = id.ToString();

            InputEmployeLastName.Text = lastname;
            InputEmployeFirstName.Text = firstname;
            InputEmployeCellPhoneNumber.Text = cellPhone;
            InputEmployeFixePhoneNumber.Text = fixePhone;
            InputEmployeEmail.Text = email;
            
            ComboBoxService.SelectedValue = service.Id;
            ComboBoxService.DisplayMemberPath = service.Name;

            ComboBoxSite.SelectedValue = site.Id;
            ComboBoxSite.DisplayMemberPath = site.Name;
        }
        /// <summary>
        /// Récupère le service auquel l'employé est rattaché
        /// </summary>
        /// <param name="id"></param>
        private Service GetEmployeService(Guid id)
        {
            return context.Service.Where(o => o.Id == id).First();
        }

        private Site GetEmployeSite(Guid id)
        {
            return context.Site.Where(o => o.Id == id).First();
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

                //Si je sélectionne un service et un site dans la liste vide, ça fonctionne.
                //Si je ne sélectionne pas de service ni de site dans la liste vide, j'ai une erreur comme quoi service et site sont null

                Guid employeId = new Guid(TextBlockEmployeId.Text);
                
                Employe currentEmploye = (Employe)context.Employe.Where(o => o.Id == employeId);

                currentEmploye.FirstName = InputEmployeFirstName.Text;
                currentEmploye.LastName = InputEmployeLastName.Text;
                currentEmploye.CellPhoneNumber = InputEmployeCellPhoneNumber.Text;
                currentEmploye.FixePhoneNumber = InputEmployeFixePhoneNumber.Text;
                currentEmploye.Email = InputEmployeEmail.Text;
                currentEmploye.ServiceId = serviceId;
                currentEmploye.SiteId = siteId;

                context.SaveChanges();
            }
        }
    }
}
