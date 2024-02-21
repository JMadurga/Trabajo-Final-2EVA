using System.ComponentModel.DataAnnotations;

namespace Teatro_dos_facetas.Model
{
    public class Obras{

        [Key]
        public int id {get; set;}

        [Required]
        public string name {get; set;}

        [Required]
        public decimal price{get; set;}
    }
}