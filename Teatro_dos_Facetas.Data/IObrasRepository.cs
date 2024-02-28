using Teatro_dos_facetas.Model;

namespace Teatro_dos_facetas.Data
{
    public interface  IObrasRepository
    {
        List<Obras> AllObras{ get; }
        void AddObra(Obras obra);
        Obras GetObra(int id);
        void ChangeObra(Obras obra);
        void RemoveObra(int id); 
        void SaveChanges();   
    }

}