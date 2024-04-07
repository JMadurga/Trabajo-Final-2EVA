using System.ComponentModel.DataAnnotations;
namespace Teatro_dos_facetas.Model
{
    public class LoginDtoIn
    {
        [Required]
        public string mail { get; set; }
        [Required]
        [StringLength(8, ErrorMessage = "La contraseña debe ser de 15 caracteres")]
        public string password { get; set; }
    }
}
