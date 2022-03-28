﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _123Pay.Models
{
    public class LoginViewModel
    {
        [DisplayName("Username")]
        [Required]
        public string UserName { get; set; }
        [DisplayName("Username")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
