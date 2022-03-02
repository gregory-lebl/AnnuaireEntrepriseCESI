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
        public int IdService { get; set; }
        public virtual Service Service { get; set; }
        public int IdSite { get; set; }
        public  virtual Site Site { get; set; }
    }
}
