using Teatro_dos_facetas.Model;

namespace Teatro_dos_facetas.Data
{
    public interface  IUserRepository
    {
        List<Users> AllUser{ get; }
        void AddUser(Users user);
        Users GetUser(int id);
        Users GetUserByCorreo (string correo);
        void ChangeUser(Users user);
        void RemoveUser(int id); 
        void SaveChanges();   
    }

}