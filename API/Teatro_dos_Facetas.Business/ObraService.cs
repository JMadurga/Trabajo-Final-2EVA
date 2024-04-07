using Teatro_dos_facetas.Data;
using Teatro_dos_facetas.Model;

namespace Teatro_dos_facetas.Business
{
    
    public class ObraService
    {
    private readonly IObrasRepository _obraRepository;

        public ObraService(IObrasRepository obrasRepository)
        {
            _obraRepository = obrasRepository;
        }
        public ObrasDTO ObrasToDTO (Obras obra){
            return new ObrasDTO
            {
                id = obra.id,
                name = obra.name,
                categoria = obra.categoria,
                synopsis = obra.synopsis
            };
           
        }
        public Obras ObrasDtoToObra (ObrasDTO obradto){
            return new Obras
            {
                id = obradto.id,
                name = obradto.name,
                categoria = obradto.categoria,
                synopsis = obradto.synopsis
            };
           
        }
        public List<Obras> GetAll() => _obraRepository.AllObras;

        public Obras? Get(int id) => _obraRepository.GetObra(id);

        public void Add(Obras obra) => _obraRepository.AddObra(obra);

        public void Update(Obras obra) => _obraRepository.ChangeObra(obra);

        public void Delete(int id) => _obraRepository.RemoveObra(id);
    }
}