using System.Collections.Generic;
using System.Collections.ObjectModel;
using SchoolApi.Models;

namespace SchoolApi.Controllers.Resources
{
    public class UserModelResources
    {
        public int Id { get; set; }

        
        public string  name { get; set; }

        
        
        public string email { get; set; }

        
        public string pass { get; set; }

        public ICollection<PhoneNumberResources> phoneNumber { get; set; }


        public UserModelResources()
        {
            phoneNumber = new Collection<PhoneNumberResources>();
        }
        
    }
}