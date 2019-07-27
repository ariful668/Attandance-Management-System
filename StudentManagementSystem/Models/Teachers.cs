using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace StudentManagementSystem.Models
{
    public partial class Teachers
    {
        public Teachers()
        {
            Attends = new HashSet<Attends>();
        }
        [Key]
        public long TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherPhone { get; set; }
        public string TeacherEmail { get; set; }
        public string TeacherGender { get; set; }
        public string TeacherAddress { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public ICollection<Attends> Attends { get; set; }
    }
}
