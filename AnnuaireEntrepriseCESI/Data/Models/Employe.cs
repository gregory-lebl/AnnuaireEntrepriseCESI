using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AnnuaireEntrepriseCESI.Data.Models
{
    public class Employe
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(10)]
        public string CellPhoneNumber { get; set; }
        [Required]
        [MaxLength(10)]
        public string FixePhoneNumber { get; set; }
        [Required]
        [MaxLength(500)]
        public string Email { get; set; }

        [DefaultValue(false)]
        public string Role { get; set; }
        [Required]
        public Guid ServiceId { get; set; }
        [Required]
        public Guid SiteId { get; set; }

        public Employe(string firstName, string lastName, string cellPhoneNumber, string fixePhoneNumber, string email, string role, Guid serviceId, Guid siteId)
        {
            Id = new Guid();
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
