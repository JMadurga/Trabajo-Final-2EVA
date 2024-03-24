
namespace Teatro_dos_facetas.Model
{
    
    public class SesionAsiento
    {
        public int sesionId { get; set; }
        public Sesion sesion { get; set; }

        public int asientoId { get; set; }
        public Asientos asiento { get; set; }

    }
}