using System.ComponentModel.DataAnnotations;
namespace Teatro_dos_facetas.Model
{
    public class LoginDtoIn
    {
        [Required]
        public string mail { get; set; }
        [Required]
        public string password { get; set; }
    }
}
