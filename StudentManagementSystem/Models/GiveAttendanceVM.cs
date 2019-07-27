using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public class GiveAttendanceVM
    {

        [Key]
        public long StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string RoomNumber { get; set; }
        public string ClassName { get; set; }
        public string SectionName { get; set; }
        public string SubjectName { get; set; }
        public string TeacherName { get; set; }

    }
    public class GiveAttendanceVMList
    {
        public List<GiveAttendanceVM> GiveAttendanceVMAll { get; set; }
    }



        
}
