using System.ComponentModel.DataAnnotations;

namespace LogIn.Models
{
    public class Registro
    {
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Nombre requerido")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }
        [Display(Name = "Teléfono")]
        [Required(ErrorMessage = "Teléfono requerido")]
        [RegularExpression(@"^[0-9]{9}$", ErrorMessage = "Teléfono incorrecto")]
        [DataType(DataType.PhoneNumber)]
        public int Telefono { get; set; }
        [Display(Name = "DNI")]
        [Required(ErrorMessage = "DNI requerido")]
        [RegularExpression(@"^[0-9]{8,8}[A-Za-z]$", ErrorMessage = "DNI incorrecto")]
        public string DNI { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Correo requerido")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                            ErrorMessage = "Email incorrecto")]
        [DataType(DataType.EmailAddress)]
        public string User { get; set; }
        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Contraseña requerida")]
        [RegularExpression(@"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,30}$", ErrorMessage = "Contraseña no segura")]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }
    }
}
