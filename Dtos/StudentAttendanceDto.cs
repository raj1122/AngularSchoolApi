using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SchoolApi.Models;

namespace SchoolApi.Dtos
{
    public class StudentAttendanceDto
    {
        public int Id { get; set; }

        public int UserModelId { get; set; }
    
        [Required]        
        public string studentName { get; set; }

        public int studentRoll { get; set; }

        public string Gender { get; set; }

        public int  Age { get; set; }

        public string StudentUrl { get; set; }

        public DateTime createdTime { get; set; }

        public string CreatedBy { get; set; }


        public string updatedBy { get; set; }

        public DateTime updatedTime { get; set; }

        public ICollection<StudDetailAttendanceModel> Features { get; set; }
    }
}