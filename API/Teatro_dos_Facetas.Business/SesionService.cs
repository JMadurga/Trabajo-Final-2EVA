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

       


        public List<SesionDTO> GetAll() { return _sesionRepository.AllSesiones.Select(s => SesionToSesionDto(s)).ToList();}
        
        public SesionDTO GetSesionById(int id)
        {
            var sesion = SesionToSesionDto(_sesionRepository.GetSesion(id));
            sesion.asientosId = _sesionRepository.GetSesionAsientos().Where(sa => sa.sesionId == id).Select(sa => sa.asientoId).ToList();
            return sesion;
        }
        
        public Sesion SesionDtoToSesion(SesionDTO sesionDto)
        {
            var sesion = new Sesion
            {
                id = sesionDto.sesionId,
                date = sesionDto.date,               
                obraId = sesionDto.obraId,
                
            };

                return sesion;
        }

    public SesionDTO SesionToSesionDto(Sesion sesion)
        {
            var sesionDto = new SesionDTO
            {
                sesionId = sesion.id,
                date = sesion.date,
                obraId = sesion.obraId,
                asientosId = sesion.SesionAsientos.Select(sa => sa.asientoId).ToList() 
               
            };
            
            return sesionDto;
        }
            
    

        public void CreateSesion(Sesion sesion)
        {

            _sesionRepository.AddSesion(sesion);
        }

        public void UpdateSesion(Sesion sesion)
        {
            
            _sesionRepository.ChangeSesion(sesion);
        }

        public void DeleteSesion(int id)
        {
           
            _sesionRepository.RemoveSesion(id);
        }
    }
}