using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApi.Models
{
    [Table("Users")]
    public class UserModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string  name { get; set; }

        
        [Required]
        [StringLength(255)]
        public string email { get; set; }

        
        [Required]
        [StringLength(255)]
        public byte[] passwordHash { get; set; }

        public byte[] passwordSalt { get; set; }

        public string Designation { get; set; }
        public string Gender { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastActive { get; set; }

        public ICollection<PhoneNumberModel> phoneNumber { get; set; }

        public ICollection<Photos> Photos { get; set; }

        public ICollection<UserDetailsModel> UserDetails { get; set; }

        public ICollection<StudentModel> StudentDetails { get; set; }        

        public UserModel()
        {
            Photos = new Collection<Photos>();
            UserDetails =  new Collection<UserDetailsModel>();            
            StudentDetails =  new  Collection<StudentModel>();            
        }

    }
} 