
using System.ComponentModel.DataAnnotations.Schema;

namespace Teatro_dos_facetas.Model
{
    
    public class SesionAsiento
    {
        [ForeignKey("sesion")]
        public int sesionId { get; set; }
        public Sesion sesion { get; set; }

        [ForeignKey("asiento")]
        public int asientoId { get; set; }
        public Asientos asiento { get; set; }

    }
}