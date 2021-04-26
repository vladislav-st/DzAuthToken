using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project_927.DataAccess.Entity
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "Full name is required field")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Address name is required field")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Age name is required field")]
        public int Age { get; set; }
    }
}
