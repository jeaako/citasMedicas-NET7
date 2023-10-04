using AutoMapper;
using citas_medicas.Models.DTO;

namespace citas_medicas.Entities.Mapper
{
    public class DiagnosticoMapper : Profile
    {
        public DiagnosticoMapper()
        {
            CreateMap<DiagnosticoDTO, Diagnostico>();
            CreateMap<Diagnostico, DiagnosticoDTO>();
        }
    }
}
