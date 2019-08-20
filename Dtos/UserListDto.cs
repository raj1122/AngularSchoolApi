using System;

namespace SchoolApi.Dtos
{
    public class UserListDto
    {
        public int Id { get; set; }


        public string  name { get; set; }

        

        public string email { get; set; }

            

        public string Designation { get; set; }
        public string Gender { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastActive { get; set; }

        // public ICollection<PhoneNumberModel> phoneNumber { get; set; }

        // public ICollection<Photos> Photos { get; set; }

        // public ICollection<UserDetailsModel> UserDetails { get; set; }

        // public ICollection<StudentModel> StudentDetails { get; set; }        

    }
}