using System.ComponentModel.DataAnnotations;

namespace Teatro_dos_facetas.Model
{
    public class Users{

        [Key]
        public int id {get; set;}
        [Required]
        public string name {get; set;}
        [Required]
        public string mail{get; set;}
        [Required]
        public string password{get; set;}
        [Required]
        public int phone{get; set;}
    }
}