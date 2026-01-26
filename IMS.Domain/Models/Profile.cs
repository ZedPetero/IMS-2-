using IMS.Domain.;
using IMS.Domain.;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Domain.Models
{
    public class Profile
    {
        [Required]
        public string FullName { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
    }
}
