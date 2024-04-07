using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic.FileIO;

namespace Teatro_dos_facetas.Model
{
    public class Pedidos{

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {get; set;}

        public double total {get; set;}

        public DateTime date {get; set;}

        [ForeignKey("userId")]
        public int userId {get; set;}

        public Users user {get; set;}

        [ForeignKey("sesionId")]
        public int sesionId {get; set;}

        
        public Sesion sesion {get; set;}   

        public List<PedidosAsiento> pedidoAsientos {get; set;}

    }
}