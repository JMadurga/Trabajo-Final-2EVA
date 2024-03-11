using System.ComponentModel.DataAnnotations;

namespace Teatro_dos_facetas.Model; // BankApp.DTO

public class PedidoCreateDTO
{
    [Required]
    public int pedidoId { get; set; }
    [Required]
    public int userId { get; set; }

    [Required]
    public int sesionId { get; set; }

    [Required]
    public int asientoId { get; set; }

}
