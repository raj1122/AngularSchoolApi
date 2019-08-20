using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApi.Models
{
    [Table("Student_Attendance_All")]
    public class StudentAttendanceModel
    {
        public int Id { get; set; }

        [Required]
        public DateTime AttendanceDate { get; set; }

        [Required]
        [StringLength(255)]
        public string studentName { get; set; }

        public int studentRoll { get; set; }

        public DateTime createdTime { get; set; }


        public string updatedBy { get; set; }

        public DateTime updatedTime { get; set; }
    }
}