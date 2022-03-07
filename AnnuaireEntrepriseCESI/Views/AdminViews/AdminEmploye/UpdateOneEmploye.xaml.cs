using AnnuaireEntrepriseCESI.Data;
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
            

            InputEmployeLastName.Text = lastname;
            InputEmployeFirstName.Text = firstname;
            InputEmployeCellPhoneNumber.Text = cellPhone;
            InputEmployeFixePhoneNumber.Text = fixePhone;
            InputEmployeEmail.Text = email;
            ComboBoxService.SelectedValue = serviceId;
            ComboBoxSite.SelectedValue = siteId;

            ComboBoxService.ItemsSource = context.Service.ToList();
            ComboBoxSite.ItemsSource = context.Site.ToList();
        }
    }
}
