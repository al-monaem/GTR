﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Token
    {
        [Key]
        public int Id { get; set; }
        public string RefreshToken { get; set; } = string.Empty;
        public int Status { get; set; } = 1;
        public DateTime ExpiresAt { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
