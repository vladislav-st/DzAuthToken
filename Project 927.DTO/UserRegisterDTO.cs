using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project_927.DTO
{
    public class UserRegisterDTO
    {
        [Required(ErrorMessage = "Email is required fields")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required fields")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Full name is required fields")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Phone is required fields")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Address is required fields")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Age is required fields")]
        [Range(15, 100, ErrorMessage = "Age range from 15 to 100")]
        public int Age { get; set; }
    }
}
