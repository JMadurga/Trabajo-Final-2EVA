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
        public List<Obras> GetAll() => _obraRepository.AllObras;

        public Obras? Get(int id) => _obraRepository.GetObra(id);

        public void Add(Obras obra) => _obraRepository.AddObra(obra);

        public void Update(Obras obra) => _obraRepository.ChangeObra(obra);

        public void Delete(int id) => _obraRepository.RemoveObra(id);
    }
}