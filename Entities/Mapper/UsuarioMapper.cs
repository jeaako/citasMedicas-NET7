using AutoMapper;
using citas_medicas.Models.DTO;

namespace citas_medicas.Entities.Mapper
{
    public class UsuarioMapper : Profile
    {
        public UsuarioMapper()
        {
            CreateMap<UsuarioDTO, Usuario>();

            CreateMap<Usuario, UsuarioDTO>();
        }
    }
}
