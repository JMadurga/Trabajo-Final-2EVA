using System.ComponentModel.DataAnnotations;

namespace Teatro_dos_facetas.Model; 

public class UserDTOin
{


    [Required]
    public string name {get; set;}
    
    [Required]
    public string mail {get; set;}

    [Required]
    public string password {get; set;}


}
