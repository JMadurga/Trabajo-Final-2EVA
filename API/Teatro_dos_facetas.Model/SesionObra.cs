
namespace Teatro_dos_facetas.Model
{
    
    public class SesionObra
    {
        public int sesionId { get; set; }
        public Sesion sesion { get; set; }

        public int obraId { get; set; }
        public Obras obra { get; set; }

    }
}