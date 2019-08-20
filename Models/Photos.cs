using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApi.Models
{
    [Table("Photos")]
    public class Photos
    {
        public int Id { get; set; }

        [Required]
        public string  Url  { get; set; }

        public DateTime CreatedAt { get; set; }
         
        public bool  isMain { get; set; }

        public int UserModelId { get; set; }

        public UserModel UserModel { get; set; }
    }
}