using System.ComponentModel.DataAnnotations;

namespace Teatro_dos_facetas.Model
{
    public class Users{

        [Key]
        public int Id {get; set;}
        [Required]
        public string Name {get; set;}
        [Required]
        public string Mail{get; set;}
        [Required]
        public string Password{get; set;}
        [Required]
        public int Phone{get; set;}
    }
}