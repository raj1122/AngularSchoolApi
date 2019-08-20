using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Models
{
    public class PhoneNumberDto
    {

        public int Id { get; set; }

        [Required]
        public long  userPhoneAll { get; set; }
        
    }
}