﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Models
{
    public class UsersModel
    {
        [Key]
        public int user_id { get; set; }

        [Required]
        public string full_name { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string role { get; set; }

        public string department { get; set; }

        public string? profile { get; set; }

        [Required]
        public DateTime created_at { get; set; }

        [Required]
        public string token { get; set; }

        public string? token_forgot { get; set; }

        public bool isRistrict { get; set; }

        // Navigation properties
        public virtual ICollection<IncidentsModel> Incidents { get; set; }
        public virtual ICollection<UpdatesModel> Updates { get; set; }
        public virtual ICollection<CommentsModel> Comments { get; set; }
        public virtual ICollection<AttachmentsModel> Attachments { get; set; }
    }
}
