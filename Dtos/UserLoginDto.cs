using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Dtos
{
    public class UserLoginDto
    {
        [Required]
        [StringLength(255)]
        public string email { get; set; }

        public string pass { get; set; }


    }
}