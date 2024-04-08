
using System.ComponentModel.DataAnnotations.Schema;

namespace Teatro_dos_facetas.Model
{
    
    public class SesionAsiento
    {
        [ForeignKey("sesion")]
        public int sesionId { get; set; }
        

        [ForeignKey("asiento")]
        public int asientoId { get; set; }
       

    }
}