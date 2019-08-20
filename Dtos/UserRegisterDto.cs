using System.ComponentModel.DataAnnotations;

namespace SchoolApi.Dtos
{
    public class UserRegisterDto
    {
        [Required]
        [StringLength(255)]
        public string email { get; set; }

        public byte[] passwordHash { get; set; }

        public byte[] passwordSalt { get; set; }


        [Required]
        [StringLength(8 , MinimumLength=4 , ErrorMessage="password must be between 4 to 8")]
        public string pass { get; set; }


        [Required]
        [StringLength(255 ,ErrorMessage="name must not be nulll")]
        public string  name { get; set; }
    }
}