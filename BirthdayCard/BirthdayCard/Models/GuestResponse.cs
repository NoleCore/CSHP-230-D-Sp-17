﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BirthdayCard.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter From")]
        public string From { get; set; }

        [Required(ErrorMessage = "Please enter To")]
        public string To { get; set; }

        [Required(ErrorMessage = "Please enter message")]
        public string Message { get; set; }

        
    }
}