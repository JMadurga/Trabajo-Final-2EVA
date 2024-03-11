using Teatro_dos_facetas.Model;

namespace Teatro_dos_facetas.Data
{
    public interface ISesionRepository
    {
        List<Sesion> AllSesiones { get; }
        void AddSesion(Sesion sesion);
        Sesion GetSesion(int id);
        void ChangeSesion(Sesion sesion);
        void RemoveSesion(int id);
        void SaveChanges();
    }
}