using System.ComponentModel.DataAnnotations;

namespace AuthWebApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El usuario es requerido")]
        [Display(Name = "Usuario")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contraseña es requerida")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; } = string.Empty;

        public string? Email { get; set; }
        public bool IsActive { get; set; } = true;
    }
}