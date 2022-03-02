﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AnnuaireEntrepriseCESI.Data.Models
{
    public class Service
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}