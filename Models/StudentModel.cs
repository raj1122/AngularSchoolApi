using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApi.Models
{
    [Table("Student")]
    public class StudentModel
    {
        public int Id { get; set; }

        public int UserModelId { get; set; }

        public UserModel userModel { get; set; }
    
        [Required]
        [StringLength(255)]
        public string studentName { get; set; }

        public int studentRoll { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string StudentUrl { get; set; }

        public DateTime createdTime { get; set; }

        public string CreatedBy { get; set; }


        public string updatedBy { get; set; }

        public DateTime updatedTime { get; set; }

        public ICollection<StudDetailAttendanceModel> Features { get; set; }

        public StudentModel()
        {
            Features = new Collection<StudDetailAttendanceModel>();
        }
    }
}