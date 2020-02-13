﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.View_Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Login")]
        public string Login { get; set; }


        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }


        [Required]
        [Display(Name = "LastName")]
        public string LastName { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }


        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string PasswordConfirm { get; set; }
    }
}
