using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.View_Models
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "*Введіть пароль")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{6,24}$", ErrorMessage = ("*Некоректний пароль"))]
        public string Password { get; set; }


        [Required(ErrorMessage = "*Підтвердіть пароль")]
        [Compare("Password", ErrorMessage = "*Паролі не співпадають")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердіть пароль")]
        public string PasswordConfirm { get; set; }
    }
}
