using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.View_Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="*Введіть логін")]
        [Display(Name = "Login")]
        public string Login { get; set; }


        [Required(ErrorMessage = "*Введіть пошту")]
        [Display(Name = "Email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage =("Некоректний email"))]
        public string Email { get; set; }


        [Required(ErrorMessage = "*Введіть ім'я")]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "*Введіть прізвище")]
        [Display(Name = "LastName")]
        public string LastName { get; set; }


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
