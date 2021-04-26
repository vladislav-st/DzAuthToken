using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project_927.DTO
{
    public class UserLoginDTO
    {
        [Required(ErrorMessage = "Email is required fields")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required fields")]
        public string Password { get; set; }
    }
}
