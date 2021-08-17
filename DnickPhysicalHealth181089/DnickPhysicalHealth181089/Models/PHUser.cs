using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnickPhysicalHealth181089.Models
{
    public class PHUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Water { get; set; }
        public virtual UserPlan UserPlan { get; set; }
        public virtual Plan Plan { get; set; }

    }
}
