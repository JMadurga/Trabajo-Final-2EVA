using Teatro_dos_facetas.Data;
using Teatro_dos_facetas.Model;

namespace Teatro_dos_facetas.Business
{
    
    public class AsientoService
    {
    private readonly IAsientoRepository _asientoRepository;

        public AsientoService(IAsientoRepository asientoRepository)
        {
            _asientoRepository = asientoRepository;
        }
            public AsientosDTO AsientoToDTO (Asientos asientos){
            return new AsientosDTO
            {
                asientoId = asientos.id,
                isFree = asientos.isFree,
                price = asientos.price,
            };
           
        }
        public Asientos AsientoDtoToAsiento (AsientosDTO asientosDTO){
            return new Asientos            {
                id = asientosDTO.asientoId,
                isFree = asientosDTO.isFree,
                price = asientosDTO.price,
    
            };
           
        }
        public List<Asientos> GetAll() => _asientoRepository.AllAsientos;

        public Asientos? Get(int id) => _asientoRepository.GetAsiento(id);
        public void Add(Asientos asiento) => _asientoRepository.AddAsiento(asiento);

        public void Update(Asientos asiento) => _asientoRepository.ChangeAsiento(asiento);

        public void Delete(int id) => _asientoRepository.RemoveAsiento(id);
    }
}