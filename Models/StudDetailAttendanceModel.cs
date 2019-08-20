using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApi.Models
{
    [Table("StudentAttendance")]
    public class StudDetailAttendanceModel
    {
        public int StudentDetailsModelId { get; set; }

        public int StudentAttendanceModelId { get; set; }
        public StudentModel StudentDetailsModel { get; set; }
        public StudentAttendanceModel StudentAttendanceModel { get; set; }

        

    }
}