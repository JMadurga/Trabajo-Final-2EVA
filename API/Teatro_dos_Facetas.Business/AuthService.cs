using System.IdentityModel.Tokens.Jwt;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Text;
using Teatro_dos_facetas.Data;
using Teatro_dos_facetas.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Teatro_dos_Facetas.Business
{
    public class AuthService 
    {
        private readonly IConfiguration _configuration;
        private readonly   IUserRepository _repository;

        public AuthService(IConfiguration configuration, IUserRepository repository)
        {
            _configuration = configuration;
            _repository = repository;
        }

        public string Login(LoginDtoIn loginDtoIn) {
            var user = _repository.GetUserFromCredentials(loginDtoIn);
            return GenerateToken(user);
        }

        public string Register(UserCreateDTO userDto) {

            var user = _repository.AddUserFromCredentials(userDto);
            return GenerateToken(user);
        }

        public string GenerateToken(UserCreateDTO userDTO) {
            var key = Encoding.UTF8.GetBytes("user_nuevo_123456789"); 
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] 
                    {
                        new Claim(ClaimTypes.NameIdentifier, Convert.ToString(userDTO.id)),
                        new Claim(ClaimTypes.Name, userDTO.name),
                        new Claim(ClaimTypes.Email, userDTO.email),
                        new Claim("myCustomClaim", "myCustomClaimValue"),
                        // add other claims
                    }),
                Expires = DateTime.UtcNow.AddDays(7), // AddMinutes(60)
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return tokenString;
        } 
     

    }
}
