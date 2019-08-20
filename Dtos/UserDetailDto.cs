using System;

namespace SchoolApi.Dtos
{
    public class UserDetailDto
    {
        public int Id { get; set; }    
        public int  Age { get; set; }
        public string  FatherName { get; set; }

        public string MotherName { get; set; }

        public DateTime Createdat { get; set; }
    }
}