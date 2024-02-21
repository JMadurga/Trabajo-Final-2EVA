using System.ComponentModel.DataAnnotations;

namespace Teatro_dos_facetas.Model
{
    public class Sesion{

        [Key]
        public int id {get; set;}

        [Required]
        public DateTime date{get; set;}
        [Required]
        public List<Obras> obraSesion{get; set;}
        [Required]
        public List<Asientos> asientos {get; set;}

    }
}