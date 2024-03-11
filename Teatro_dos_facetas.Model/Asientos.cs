using System.ComponentModel.DataAnnotations;

namespace Teatro_dos_facetas.Model
{
    public class Asientos{

        [Key]
        public int id {get; set;}

        
        [Required]
        public bool isFree {get; set;} = true;

        public List<SesionAsiento> SesionAsientos { get; set; }
    }
}