using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace StudentManagementSystem.Models
{
    public partial class Subjects
    {
        public Subjects()
        {
            Attends = new HashSet<Attends>();
        }
        [Key]
        public long SubjectId { get; set; }
        public string SubjectName { get; set; }

        public Subjects Subject { get; set; }
        public Subjects InverseSubject { get; set; }
        public ICollection<Attends> Attends { get; set; }
    }
}
