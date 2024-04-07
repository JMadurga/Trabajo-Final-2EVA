using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Teatro_dos_facetas.Model; // BankApp.DTO

public class AsientosDTO
{
    [Required]
    public int asientoId {get; set;}

    [Required]
    public bool isFree{get;set;}

    [Required]
    public double price{get;set;}
 
}
