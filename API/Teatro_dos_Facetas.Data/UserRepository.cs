using Teatro_dos_facetas.Model;
using Microsoft.EntityFrameworkCore;

namespace Teatro_dos_facetas.Data{
    public class UserRepository: IUserRepository
    {

        private readonly   TeatroContext _context;
        public List<Users> AllUser => _context.Users.ToList();


        public UserRepository(TeatroContext context)
        {
            _context = context;
        }
        public void AddUser(Users user)
        {
            _context.Users.Add(user);
            SaveChanges();
        }
        public Users GetUser (int id)
        {
            return _context.Users.FirstOrDefault(user => user.id == id);
        }

        public Users GetUserByCorreo (string correo)
        {
            return _context.Users.FirstOrDefault(user => user.mail == correo);
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

        public UserCreateDTO AddUserFromCredentials(UserCreateDTO userDtoIn) {
            if (GetUserByCorreo(userDtoIn.mail) != null)
            {
                throw new KeyNotFoundException("User already exists.");
            }
            var user = new Users { name = userDtoIn.name, mail = userDtoIn.mail, password = userDtoIn.password, phone = userDtoIn.phone};
            AddUser(user); 
            return new UserCreateDTO { id = user.id, name = user.name, mail = user.mail, phone = user.phone};
        }
        
        public UserCreateDTO GetUserFromCredentials(LoginDtoIn loginDtoIn) {
            var user = GetUserByCorreo(loginDtoIn.mail);
            if (user == null)
            {
                
                throw new KeyNotFoundException("User not found.");
            }
            if (user.password != loginDtoIn.password)
            {
                
                throw new KeyNotFoundException("Password incorrect.");
            }
            return new UserCreateDTO { id = user.id, name = user.name, mail = user.mail, phone = user.phone};
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }

}