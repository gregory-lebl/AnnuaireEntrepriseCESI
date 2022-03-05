using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnuaireEntrepriseCESI.Data.ViewModels
{
    class EmployeViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CellPhoneNumber { get; set; }
        public string FixePhoneNumber { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string ServiceName { get; set; }
        public string SiteName { get; set; }

        public EmployeViewModel(string firstName, string lastName, string cellPhoneNumber, string fixePhoneNumber, string email, string role, string serviceName, string siteName)
        {
            FirstName = firstName;
            LastName = lastName;
            CellPhoneNumber = cellPhoneNumber;
            FixePhoneNumber = fixePhoneNumber;
            Email = email;
            Role = role;
            ServiceName = serviceName;
            SiteName = siteName;
        }
    }
}
