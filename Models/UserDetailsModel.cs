using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApi.Models
{
    [Table("UserDetails")]
    public class UserDetailsModel
    {
        public int Id { get; set; }    
        public DateTime DateOfBirth { get; set; }
        public string  FatherName { get; set; }

        public string MotherName { get; set; }

        public DateTime Createdat { get; set; }

        public int UserModelId { get; set; }

        public UserModel UserModel { get; set; }        
    }
}