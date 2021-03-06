﻿using System.ComponentModel.DataAnnotations;

namespace Final.WebSite.Models
{
    public class LoginModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}