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
                    
                SesionObras = sesionDto.sesionObras.Select(soDto => new SesionObra 
                        { 
                            sesionId= soDto.SesionId, 
                            obraId = soDto.ObraId 

                        }).ToList(),
              
                SesionAsientos = sesionDto.sesionAsientos.Select(saDto => new SesionAsiento 
                        { 
                            sesionId = saDto.SesionId, 
                            asientoId = saDto.AsientoId 

                        }).ToList(),
                };

                return sesion;
        }
    public SesionDTO SesionToSesionDto(Sesion sesion)
        {
            var sesionDto = new SesionDTO
            {
                sesionId = sesion.id,
                date = sesion.date,

                sesionObras = sesion.SesionObras.Select(so => new SesionObraDTO
                {
                    ObraId = so.obraId 
                }).ToList(),

                sesionAsientos = sesion.SesionAsientos.Select(sa => new SesionAsientoDTO
                {
                    AsientoId = sa.asientoId 
                }).ToList(),
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