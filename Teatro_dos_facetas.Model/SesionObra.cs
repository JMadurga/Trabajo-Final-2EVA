
namespace Teatro_dos_facetas.Model
{
    
    public class SesionObra
    {
        public int SesionId { get; set; }
        public Sesion sesion { get; set; }

        public int ObraId { get; set; }
        public Obras obra { get; set; }

    }
}