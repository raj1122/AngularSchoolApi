using System.Collections.Generic;
using SchoolApi.Models;

namespace SchoolApi.Dtos
{
    public class UserAllDetailDto
    {

        public int Id { get; set; }

        
        public string  name { get; set; }

        
        
        public string email { get; set; }
            

        public ICollection<PhoneNumberDto> phoneNumber { get; set; }

        public ICollection<UserDetailDto> userDetails { get; set; }


        
        
    }
}