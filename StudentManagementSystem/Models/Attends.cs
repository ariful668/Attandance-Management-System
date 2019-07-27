using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace StudentManagementSystem.Models
{
    public partial class Attends
    {
        [Key]
        public long AttendId { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string RoomNumber { get; set; }
        public string Remark { get; set; }
        /*
        public long? ClassId { get; set; }
        public long? SectionId { get; set; }
        public long? StudentId { get; set; }
        public long? SubjectId { get; set; }
        public long? TeacherId { get; set; }
        */

        public Classes Class { get; set; }
        public Sections Section { get; set; }
        public Students Student { get; set; }
        public Subjects Subject { get; set; }
        public Teachers Teacher { get; set; }
    }
}
