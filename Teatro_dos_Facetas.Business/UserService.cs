using Teatro_dos_facetas.Data;
using Teatro_dos_facetas.Model;

namespace Teatro_dos_facetas.Business
{
    
    public class UserService
    {
    private readonly IUserRepository _usuarioRepository;

        public UserService(IUserRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public List<Users> GetAll() => _usuarioRepository.AllUser;

        public Users? Get(int id) => _usuarioRepository.GetUser(id);

        public void Add(Users usuario) => _usuarioRepository.AddUser(usuario);

        public void Update(Users usuario) => _usuarioRepository.ChangeUser(usuario);

        public void Delete(int id) => _usuarioRepository.RemoveUser(id);
    }
}