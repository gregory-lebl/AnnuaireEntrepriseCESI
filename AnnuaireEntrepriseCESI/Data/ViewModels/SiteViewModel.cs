using AnnuaireEntrepriseCESI.Data.StorageModels;
using System;

namespace AnnuaireEntrepriseCESI.Data.ViewModels
{
    class SiteViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public SiteViewModel(Site site)
        {
            Id = site.Id;
            Name = site.Name;
            Description = site.Description;
        }
    }
}
