using System;

namespace SchoolApi.Controllers.Resources
{
    public class AuditResource
     {

        public DateTime createdTime { get; set; }
    
        public string CreatedBy { get; set; }

        
        public string updatedBy { get; set; }

        public DateTime updatedTime { get; set; }

    }
}