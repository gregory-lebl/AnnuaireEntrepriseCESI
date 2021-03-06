using System;
using System.ComponentModel.DataAnnotations;

namespace AnnuaireEntrepriseCESI.Data.StorageModels
{
    public class Admin
    {
        public Guid Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public Admin(string email, string password)
        {
            Id = Guid.NewGuid();
            Email = email;
            Password = password;
        }
    }
}
