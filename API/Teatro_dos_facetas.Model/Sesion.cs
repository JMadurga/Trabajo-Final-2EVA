using System.ComponentModel.DataAnnotations;

namespace Teatro_dos_facetas.Model
{
    public class Sesion{

        [Key]
        public int id {get; set;}

        [Required]
        public DateTime date {get; set;}

        [Required]
        public List<SesionObra> SesionObras {get; set;}
        
        [Required]
        public List<SesionAsiento> SesionAsientos{get; set;}

        public List<PedidoSesion> pedidoSesion{get; set;}

    }
}