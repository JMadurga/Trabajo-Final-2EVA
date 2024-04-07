using Teatro_dos_facetas.Model;
using Microsoft.EntityFrameworkCore;

namespace Teatro_dos_facetas.Data{
    public class SesionRepository: ISesionRepository
    {

        private readonly TeatroContext _context;
        public List<Sesion> AllSesiones => _context.Sesiones.ToList();


        public SesionRepository(TeatroContext context)
        {
            _context = context;
        }
        public void AddSesion(Sesion sesion)
        {
            _context.Sesiones.Add(sesion);
            SaveChanges();
        }
        public Sesion GetSesion(int id)
        {
            return _context.Sesiones.FirstOrDefault(sesion => sesion.id == id);
        }
 

        public void ChangeSesion(Sesion sesion)
        {
            // En EF Core, si el objeto ya est
            _context.Entry(sesion).State = EntityState.Modified;
        }
        public void RemoveSesion(int id) {
            
            var sesion = GetSesion(id);
            if (sesion == null) {
                throw new KeyNotFoundException("Sesion not found.");
            }
            _context.Sesiones.Remove(sesion);
            SaveChanges();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }

}