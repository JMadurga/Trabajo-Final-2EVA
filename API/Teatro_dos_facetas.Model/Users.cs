using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teatro_dos_facetas.Model
{
    public class Users{

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {get; set;}
        [Required]
        public string name {get; set;}
        [Required]
        public string mail{get; set;}
        [Required]
        public string password{get; set;}
        [Required]
        public int phone{get; set;}

        public List<Pedidos> pedidos {get; set;}
    }
}