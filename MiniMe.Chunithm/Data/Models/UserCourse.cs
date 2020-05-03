﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MiniMe.Chunithm.Data.Models
{
    public class UserCourse : Protocols.UserCourse
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public Guid ProfileId { get; set; }
    }
}
