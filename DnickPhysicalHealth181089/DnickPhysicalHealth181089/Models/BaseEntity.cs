using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DnickPhysicalHealth181089.Models
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
