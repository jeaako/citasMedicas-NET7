using AutoMapper;
using citas_medicas.Models.DTO;

namespace citas_medicas.Entities.Mapper
{
    public class MedicoMapper : Profile
    {
        public MedicoMapper()
        {
            CreateMap<MedicoDTO, Medico>()
                .ForMember(med => med.Citas, o => o.MapFrom(dto => new List<Cita>()))
                .ForMember(med => med.Pacientes, o => o.MapFrom(dto => new List<Paciente>()));

            CreateMap<Medico, MedicoDTO>()
            .ForMember(mdto => mdto.Citas, o => o.MapFrom(med => med.Citas.Select(c => c.Id).ToList()))
            .ForMember(mdto => mdto.Pacientes, o => o.MapFrom(med => med.Pacientes.Select(p => p.Id).ToList()));

        }
    }
}
