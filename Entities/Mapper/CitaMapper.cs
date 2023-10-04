using AutoMapper;
using citas_medicas.Models.DTO;
using System.Globalization;

namespace citas_medicas.Entities.Mapper
{
    public class CitaMapper : Profile
    {
        public CitaMapper()
        {
            CreateMap<CitaDTO, Cita>()
                .ForMember(c => c.FechaHora,
                o => o.MapFrom(cdto => DateTime.ParseExact(cdto.FechaHora, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture)));


            CreateMap<Cita, CitaDTO>()
                .ForMember(cdto => cdto.FechaHora, o => o.MapFrom(c=> c.FechaHora.ToString("dd-MM-yyyy HH:mm")))
                //.ForMember(cdto => cdto.Medico, o => o.MapFrom(c => c.Medico.Id))
                //.ForMember(cdto => cdto.Paciente, o => o.MapFrom(c => c.Paciente.Id))
                .ForMember(cdto => cdto.Diagnostico, o => o.MapFrom(c => c.Diagnostico.Id)); ; 
        }
    }
}
