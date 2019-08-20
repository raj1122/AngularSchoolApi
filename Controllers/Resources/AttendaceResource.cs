using System;

namespace SchoolApi.Controllers.Resources
{
    public class AttendaceResource
    {
        public int Id { get; set; }

        
        public DateTime AttendanceDate { get; set; }

        
        public string studentName { get; set; }

        public int studentRoll { get; set; }

        public DateTime createdTime { get; set; }


        public string updatedBy { get; set; }

        public DateTime updatedTime { get; set; }
        
    }
}