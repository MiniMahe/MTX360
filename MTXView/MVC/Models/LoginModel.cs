using System.ComponentModel.DataAnnotations;

namespace LogIn.Models
{
    public class Login
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Correo requerido")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                            ErrorMessage = "Email incorrecto")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Contraseña requerida")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
