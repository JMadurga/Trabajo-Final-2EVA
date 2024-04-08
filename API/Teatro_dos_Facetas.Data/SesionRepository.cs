using Teatro_dos_facetas.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

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
            
            foreach (var asiento in _context.Asientos.ToList())
            {
                _context.SesionAsientos.Add(new SesionAsiento
                {
                    sesionId = sesion.id,
                    asientoId = asiento.id,
                });
                SaveChanges();
            }
         
  
        }
        public Sesion GetSesion(int id)
        {
            return _context.Sesiones.FirstOrDefault(sesion => sesion.id == id);
        }
        public List<SesionAsiento> GetSesionAsientos()
        {
            return _context.SesionAsientos.ToList();
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