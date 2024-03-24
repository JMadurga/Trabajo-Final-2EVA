using System.ComponentModel.DataAnnotations;

namespace Teatro_dos_facetas.Model; 

public class SesionCreateDTO
{
    [Key]
    public int sesionId {get; set;}
    [Required]
    public DateTime fecha {get; set;}
    [Required]
    public List<SesionObraDTO> sesionObras {get; set;}
    [Required]
    public List<SesionAsientoDTO> sesionAsientos {get; set;}
    
}
