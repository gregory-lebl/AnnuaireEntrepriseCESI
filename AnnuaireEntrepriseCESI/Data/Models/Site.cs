﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AnnuaireEntrepriseCESI.Data.Models
{
    public class Site
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}