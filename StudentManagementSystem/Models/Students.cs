using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace StudentManagementSystem.Models
{
    public partial class Students
    {
        public Students()
        {
            Attends = new HashSet<Attends>();
        }
        [Key]
        public long StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentGender { get; set; }
        public string StudentAddress { get; set; }
        public string FatherName { get; set; }
        public string FatherPhone { get; set; }
        public string MotherName { get; set; }
        public string MotherPhone { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public ICollection<Attends> Attends { get; set; }
    }
}
