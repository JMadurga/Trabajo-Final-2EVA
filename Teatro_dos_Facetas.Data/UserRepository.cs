using Teatro_dos_facetas.Model;
using Microsoft.EntityFrameworkCore;

namespace Teatro_dos_facetas.Data{
    public class UserRepository: IUserRepository
    {

        private readonly   UserContext _context;
        public List<Users> AllUser => _context.Users.ToList();


        public UserRepository(UserContext context)
        {
            _context = context;
        }
        public void AddUser(Users user)
        {
            _context.Users.Add(user);
            SaveChanges();
        }
        public Users GetUser (int Id)
        {
            return _context.Users.FirstOrDefault(user => user.Id == Id);
        }

        public void ChangeUser(Users user)
        {
            // En EF Core, si el objeto ya está siendo rastreado, actualizar sus propiedades
            // y llamar a SaveChanges() es suficiente para actualizarlo en la base de datos.
            // Asegúrate de que el estado del objeto sea 'Modified' si es necesario.
            _context.Entry(user).State = EntityState.Modified;
        }
        public void RemoveUser(int id) {
            
            var user = GetUser(id);
            if (id == null) {
                throw new KeyNotFoundException("User not found.");
            }
            _context.Users.Remove(user);
            SaveChanges();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }

}