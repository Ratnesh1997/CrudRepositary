using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudRepositary.Models
{
    public class Emp
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Gender { get; set; }
        public int age { get; set; }

        public string Email { get; set; }
    }
}
