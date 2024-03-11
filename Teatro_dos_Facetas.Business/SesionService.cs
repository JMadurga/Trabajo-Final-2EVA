using System;
using System.Collections.Generic;
using Teatro_dos_facetas.Data;
using Teatro_dos_facetas.Model;


namespace Teatro_dos_Facetas.Business
{
    public class SesionService
    {
        private readonly ISesionRepository _sesionRepository;

        public SesionService(ISesionRepository sesionRepository)
        {
            _sesionRepository = sesionRepository;
        }

        // Aquí puedes agregar los métodos de tu servicio, por ejemplo:

        public List<Sesion> GetAll() => _sesionRepository.AllSesiones;
        public Sesion GetSesionById(int id)
        {
            return _sesionRepository.GetSesion(id);
        }

        public void CreateSesion(Sesion sesion)
        {
            // Aquí puedes agregar lógica adicional antes de guardar la sesión en el repositorio
            _sesionRepository.AddSesion(sesion);
        }

        public void UpdateSesion(Sesion sesion)
        {
            // Aquí puedes agregar lógica adicional antes de actualizar la sesión en el repositorio
            _sesionRepository.ChangeSesion(sesion);
        }

        public void DeleteSesion(int id)
        {
            // Aquí puedes agregar lógica adicional antes de eliminar la sesión del repositorio
            _sesionRepository.RemoveSesion(id);
        }
    }
}