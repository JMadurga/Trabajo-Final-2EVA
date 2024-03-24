using Teatro_dos_facetas.Model;
using Microsoft.EntityFrameworkCore;

namespace Teatro_dos_facetas.Data{
    public class ObrasRepository: IObrasRepository
    {

        private readonly   TeatroContext _context;
        public List<Obras> AllObras => _context.Obras.ToList();


        public ObrasRepository(TeatroContext context)
        {
            _context = context;
        }
        public void AddObra(Obras obras)
        {
            _context.Obras.Add(obras);
            SaveChanges();
        }
        public Obras GetObra (int id)
        {
            return _context.Obras.FirstOrDefault(obras => obras.id == id);
        }

        public Obras GetObraCategoria (string categoria)
        {
            return _context.Obras.FirstOrDefault(obras => obras.categoria == categoria);
        }


        public void ChangeObra(Obras obra)
        {
            // En EF Core, si el objeto ya está siendo rastreado, actualizar sus propiedades
            // y llamar a SaveChanges() es suficiente para actualizarlo en la base de datos.
            // Asegúrate de que el estado del objeto sea 'Modified' si es necesario.
            _context.Entry(obra).State = EntityState.Modified;
        }
        public void RemoveObra(int id) {
            
            var obra = GetObra(id);
            if (id == null) {
                throw new KeyNotFoundException("Obra not found.");
            }
            _context.Obras.Remove(obra);
            SaveChanges();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }

}