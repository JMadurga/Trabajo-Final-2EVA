using System.ComponentModel.DataAnnotations;

namespace Teatro_dos_facetas.Model; // BankApp.DTO

public class PedidoCreateDTO
{

    
    public int userId { get; set; }
    
   
    public int sesionId { get; set; }

    
    public List<int> asientosId { get; set; }
}
