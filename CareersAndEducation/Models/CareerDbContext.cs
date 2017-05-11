using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CareersAndEducation.Models
{
    public class CareerDbContext:DbContext
    {
        public DbSet<Identity> Identities{ get; set; }
    }
}