using System.ComponentModel.DataAnnotations;

namespace Teatro_dos_facetas.Model
{
    public class Asientos{

        [Key]
        public int id {get; set;}

        [Required]
        public Boolean ocuppied {get; set;}
    }
}