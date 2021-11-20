using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore3.Models
{
    public class Student
    {
        public bool rememberMe { get; set; }
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Branch { get; set; }
        [Required]

        public int Mobile { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int WDDN { get; set; }
        [Required]
        public int OS { get; set; }
        [Required]
        public int MFP { get; set; }
        [Required]
        public int AT { get; set; }
        [Required]
        public int AA { get; set; }
        [Required]
        public int Teacher_id { get; set; }
        public Teacher Teacher { get; set; }
    }
}
