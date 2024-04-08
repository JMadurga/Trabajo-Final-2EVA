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

        
        public UserCreateDTO UserToDTO (Users user){
            return new UserCreateDTO
            {   
                name = user.name,
                email = user.mail,
                password = user.password,
            };
           
        }
        public Users UserDtoToUser (UserCreateDTO userdto){
            return new Users
            {
                id = userdto.id,
                name = userdto.name,
                mail = userdto.email,
                password = userdto.password,
                phone = userdto.phone
            };
           
        }

        public Users LoginDtoinToUser (LoginDtoIn userdto){
            return new Users
            {
                mail = userdto.email,
                password = userdto.password,
               
            };
           
        }
        public List<Users> GetAll() => _usuarioRepository.AllUser;

        public Users? Get(int id) => _usuarioRepository.GetUser(id);

        public Users? GetByCorreo(string correo) => _usuarioRepository.GetUserByCorreo(correo);

        public void Add(Users usuario) => _usuarioRepository.AddUser(usuario);

        public void Update(Users usuario) => _usuarioRepository.ChangeUser(usuario);

        public void Delete(int id) => _usuarioRepository.RemoveUser(id);
    }
}