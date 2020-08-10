using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperexapem.Models
{
    public class UsersDTO
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
    }
}