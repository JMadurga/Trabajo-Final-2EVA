using System.ComponentModel.DataAnnotations;

namespace Teatro_dos_facetas.Model; 

public class SesionDTO
{
    [Key]
    public int sesionId {get; set;}
    [Required]
    public DateTime date {get; set;}

    [Required]
    public List<SesionObraDTO> sesionObras {get; set;}

    [Required]
    public List<SesionAsientoDTO> sesionAsientos {get; set;}
    
}
