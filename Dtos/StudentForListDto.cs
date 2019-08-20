using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Dtos
{
    public class StudentForListDto
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
        
    }
}