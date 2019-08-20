using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApi.Models
{
    [Table("Users_Phone_Number")]
    public class PhoneNumberModel
    {

        public int Id { get; set; }

        [Required]
        public long  userPhoneAll { get; set; }

        public UserModel UserModel { get; set; }

        public int UserModelId { get; set; } //always use full class name 
                                    // to create foreign key 
        
    }
}