using System.ComponentModel.DataAnnotations;

namespace Teatro_dos_facetas.Model; // BankApp.DTO

public class UserCreateDTO
{
    [Required]
    public int userId {get; set;}

    [Required]
    public string name {get; set;}
    
    [Required]
    public string email {get; set;}

    [Required]
    public string password {get; set;}
    
    [Required]
    public int phone {get; set;}

}
