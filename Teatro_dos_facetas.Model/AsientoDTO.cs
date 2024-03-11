using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Teatro_dos_facetas.Model; // BankApp.DTO

public class AsientosRepositoryCreateDTO
{
    [Required]
    public int asientoId {get; set;}

    [Required]
    public bool isFree{get;set;}
 
}
