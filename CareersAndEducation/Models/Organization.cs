using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace CareersAndEducation.Models
{
    public class Organization : Identity
    {
        public Organization()
        {
            this.Role = "organization";
        }
       
  //      public string OrganizationName { get; set; }

  //     public string Profile { get; set; }

  //      public string Url { get; set; }

   //     public string ContactPerson { get; set; }

   //     public string ContactPhone { get; set; }

    }
}