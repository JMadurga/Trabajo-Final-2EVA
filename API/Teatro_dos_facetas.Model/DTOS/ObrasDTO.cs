using System.ComponentModel.DataAnnotations;

namespace Teatro_dos_facetas.Model
{
    public class ObrasDTO{

        [Key]
        public int id {get; set;}

        [Required]
        public string name {get; set;}

        [Required]
        public string categoria {get; set;}

        [Required]
        public string synopsis{get; set ;}

    }
}