using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public partial class Admins
    {
        [Key]
        public long AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminPhone { get; set; }
        public string AdminEmail { get; set; }
    }
}
