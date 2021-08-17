using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DnickPhysicalHealth181089.Models
{
    public class UserPlan : BaseEntity
    {
        public string UserId { get; set; }
        public PHUser User { get; set; }

        [BindProperty, DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        [NotMapped]
        public List<String> Injuries { get; set; }
    }
}
