
namespace Teatro_dos_facetas.Model
{
    
    public class SesionAsiento
    {
        public int SesionId { get; set; }
        public Sesion sesion { get; set; }

        public int AsientoId { get; set; }
        public Asientos asiento { get; set; }

    }
}