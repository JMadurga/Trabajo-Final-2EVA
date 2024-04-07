using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teatro_dos_facetas.Model
{
    public class Asientos{

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {get; set;}

        
        [Required]
        public bool isFree {get; set;} = true;

                
        [Required]
        public double price {get; set;} 

        
        public List<SesionAsiento> SesionAsientos { get; set; }


    }
}