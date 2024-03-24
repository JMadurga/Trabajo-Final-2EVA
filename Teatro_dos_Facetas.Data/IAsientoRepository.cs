using Teatro_dos_facetas.Model;

namespace Teatro_dos_facetas.Data
{
    public interface  IAsientoRepository
    {
        List<Asientos> AllAsientos{ get; }
        void AddAsiento(Asientos asiento);
        Asientos GetAsiento(int id);
        void ChangeAsiento(Asientos asiento);
        void RemoveAsiento(int id); 
        void SaveChanges();   
    }

}