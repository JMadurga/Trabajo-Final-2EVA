

using Teatro_dos_facetas.Model;

namespace Teatro_dos_facetas.Business
{
    public interface IAutorizacionService
    {
       
        public string Login(LoginDtoIn userDtoIn);
        public string Register(UserCreateDTO userDtoIn);
        public string GenerateToken(UserCreateDTO userDTOOut);
    }
}

