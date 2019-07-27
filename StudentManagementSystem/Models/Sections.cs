using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace StudentManagementSystem.Models
{
    public partial class Sections
    {
        public Sections()
        {
            Attends = new HashSet<Attends>();
        }
        [Key]
        public long SectionId { get; set; }
        public string SectionName { get; set; }

        public ICollection<Attends> Attends { get; set; }
    }
}
