using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.View_Models
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "*Введіть пошту")]
        [Display(Name = "Email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = ("Некоректний email"))]
        public string Email { get; set; }
    }
}
