using Teatro_dos_facetas.Data;
using Teatro_dos_facetas.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;


namespace Teatro_dos_facetas.Business
{

    public class AutorizacionService : IAutorizacionService {
        private readonly IConfiguration _configuration;
        private readonly IUserRepository _repository;
        private readonly UserService _service
        ;

        public AutorizacionService(IConfiguration configuration, IUserRepository repository, UserService userService)
        {
            _configuration = configuration;
            _repository = repository;
            _service = userService;
        }
        public string Login(LoginDtoIn loginDtoIn) {
            var userdto = _repository.GetUserByCorreo(loginDtoIn.mail);

            var user = _service.;
            return GenerateToken(user);
        }

        public string Register(UserCreateDTO userDto) {
            var user = _repository.AddUser(userDto.);

            return GenerateToken(user);
        }

        public string GenerateToken(UserCreateDTO userDTO) {
            var key = Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]); 
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = _configuration["JWT:ValidIssuer"],
                Audience = _configuration["JWT:ValidAudience"],
                Subject = new ClaimsIdentity(new Claim[] 
                    {
                        new Claim(ClaimTypes.NameIdentifier, Convert.ToString(userDTO.userId)),
                        new Claim(ClaimTypes.Name, userDTO.name),
                        new Claim(ClaimTypes.Role, userDTOOut.Role),
                        new Claim(ClaimTypes.Email, userDTOOut.Email),
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