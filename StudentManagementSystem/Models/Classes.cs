using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace StudentManagementSystem.Models
{
    public partial class Classes
    {
        public Classes()
        {
            Attends = new HashSet<Attends>();
        }
        [Key]
        public long ClassId { get; set; }
        public string ClassName { get; set; }

        public ICollection<Attends> Attends { get; set; }
    }
}
