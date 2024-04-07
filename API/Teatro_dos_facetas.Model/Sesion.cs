using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teatro_dos_facetas.Model
{
    public class Sesion{

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id {get; set;}

        [Required]
        public DateTime date {get; set;}

        [Required]
        [ForeignKey("obraId")]
        public int obraId {get; set;}

        public Obras obra {get; set;}
        
        
        public List<SesionAsiento> SesionAsientos{get; set;} = new List<SesionAsiento>();


        public List<Pedidos> pedidos{get; set;}

        public override string ToString(){
            return $"id: {id}, date: {date}, SesionAsientos: {string.Join("\t", SesionAsientos)}";
        }

    }
}