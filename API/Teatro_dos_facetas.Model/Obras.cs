using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teatro_dos_facetas.Model
{
    public class Obras{

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {get; set;}

        [Required]
        public string name {get; set;}

        [Required]
        public string categoria {get; set;}

        [Required]
        public string synopsis{get; set ;}

        public List<Sesion> sesiones {get; set;}
    }
}