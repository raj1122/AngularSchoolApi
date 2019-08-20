using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using SchoolApi.Models;
using SchoolApi.Controllers.Resources;

namespace SchoolApi.Controllers.Resources
{
    public class DetailResource
    {
        

        public int Id { get; set; }

        public int UserModelId { get; set; }



        [Required]
        [StringLength(255)]
        public string studentName { get; set; }

        public int studentRoll { get; set; }

        public AuditResource audit { get; set; }


        public ICollection<int> Features { get; set; }

        public DetailResource()
        {
            Features = new Collection<int>();
        }

    }
}