﻿using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace IMS.Models
{
    public class DepartmentsModel
    {
        [Key]
        public int department_id { get; set; }

        [Required]
        public string department { get; set; }

        [Required]
        public string description { get; set; }

        public string? token { get; set; }

        public string? ImagePath { get; set; } 
    }
}
