using System.ComponentModel.DataAnnotations;

namespace Teatro_dos_facetas.Model; // BankApp.DTO

public class UserCreateDTO
{
    [Required]
    public int userId {get; set;}

}
