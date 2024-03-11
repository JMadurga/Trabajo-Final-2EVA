using System.ComponentModel.DataAnnotations;

namespace Teatro_dos_facetas.Model; // BankApp.DTO

public class SesionCreateDTO
{
    [Required]
    public int obraId {get; set;}

}
