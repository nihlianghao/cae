using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CareersAndEducation.Models
{
    public class Student :Identity
    {
        public Student()
        {
            this.Role = "studnet";
        }

 //       public string Name { get; set; }

 //       public string Profile { get; set; }
 
 //       public string ContactPhone { get; set; }
    }
}