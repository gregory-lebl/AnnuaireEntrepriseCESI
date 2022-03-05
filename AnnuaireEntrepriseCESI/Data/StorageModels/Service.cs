using System;
using System.ComponentModel.DataAnnotations;

namespace AnnuaireEntrepriseCESI.Data.StorageModels
{
    public class Service
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        public Service(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

    }
}
