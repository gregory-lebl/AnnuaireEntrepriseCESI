using System;
using System.ComponentModel.DataAnnotations;

namespace AnnuaireEntrepriseCESI.Data.StorageModels
{
    public class Employe
    {
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string CellPhoneNumber { get; set; }
        [Required]
        public string FixePhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        public string Role { get; set; }
        [Required]
        public Guid ServiceId { get; set; }
        [Required]
        public Guid SiteId { get; set; }

        public Employe(string firstName, string lastName, string cellPhoneNumber, string fixePhoneNumber, string email, string role, Guid serviceId, Guid siteId)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            CellPhoneNumber = cellPhoneNumber;
            FixePhoneNumber = fixePhoneNumber;
            Email = email;
            Role = role;
            ServiceId = serviceId;
            SiteId = siteId;
        }
    }
}
