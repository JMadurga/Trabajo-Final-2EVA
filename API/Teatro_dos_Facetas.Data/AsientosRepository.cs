using Teatro_dos_facetas.Model;
using Microsoft.EntityFrameworkCore;

namespace Teatro_dos_facetas.Data{
    public class AsientosRepository: IAsientoRepository
    {

        private readonly   TeatroContext _context;
        public List<Asientos> AllAsientos => _context.Asientos.ToList();


        public AsientosRepository(TeatroContext context)
        {
            _context = context;
        }
        public void AddAsiento(Asientos asiento)
        {
            asiento.id = 0;
            _context.Asientos.Add(asiento);
            SaveChanges();
        }
        public Asientos GetAsiento(int id)
        {
            return _context.Asientos.FirstOrDefault(asiento => asiento.id == id);
        }

        public void ChangeAsiento(Asientos asiento)
        {
            // En EF Core, si el objeto ya está siendo rastreado, actualizar sus propiedades
            // y llamar a SaveChanges() es suficiente para actualizarlo en la base de datos.
            // Asegúrate de que el estado del objeto sea 'Modified' si es necesario.
            _context.Entry(asiento).State = EntityState.Modified;
        }
        public void RemoveAsiento(int id) {
            
            var asiento = GetAsiento(id);
            if (id == null) {
                throw new KeyNotFoundException("Asiento not found.");
            }
            _context.Asientos.Remove(asiento);
            SaveChanges();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }

}