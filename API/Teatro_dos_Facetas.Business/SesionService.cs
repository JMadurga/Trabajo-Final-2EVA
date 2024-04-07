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

       


        public List<Sesion> GetAll() => _sesionRepository.AllSesiones;
        public Sesion GetSesionById(int id)
        {
            return _sesionRepository.GetSesion(id);
        }
        
        public Sesion SesionDtoToSesion(SesionDTO sesionDto)
        {
            var sesion = new Sesion
            {
                id = sesionDto.sesionId,
                date = sesionDto.date,
                    
                SesionObras = new List<SesionObra> { new SesionObra
                    {
                        sesionId = sesionDto.sesionId,
                        obraId = sesionDto.obraId
                    }
                } 

            };
                return sesion;
        }

    public SesionDTO SesionToSesionDto(Sesion sesion)
        {
            var sesionDto = new SesionDTO
            {
                sesionId = sesion.id,
                date = sesion.date,
                obraId = sesion.SesionObras.Select(so => so.obraId).FirstOrDefault(),
                asientosId = sesion.SesionAsientos.Select(sa => sa.asientoId).ToList() 
               
            };
            
            return sesionDto;
        }
            
    

        public void CreateSesion(Sesion sesion)
        {
            for (int i = 1; i <= 40; i++)
            {
                sesion.SesionAsientos[i].sesionId = sesion.id;
            }

            
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