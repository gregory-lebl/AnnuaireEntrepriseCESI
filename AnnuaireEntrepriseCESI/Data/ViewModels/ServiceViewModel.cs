using System;

namespace AnnuaireEntrepriseCESI.Data.ViewModels
{
    class ServiceViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ServiceViewModel(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
