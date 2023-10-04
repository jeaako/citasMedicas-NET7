
using citas_medicas.Entities;
using citas_medicas.Repositories;

namespace citas_medicas.Services
{
    public class UsuarioService : IUsuarioService
    {

        private UsuarioRepository repositorio;

        public UsuarioService(UsuarioRepository usuarioRepository)
        {
            repositorio = usuarioRepository;
        }

        public List<Usuario> GetAllUsuarios() => repositorio.GetAll();
        public Usuario GetUsuarioById(long id) => repositorio.GetById(id);
        public Usuario AddUsuario(Usuario nuevoUsuario) => repositorio.Add(nuevoUsuario);
        public Usuario DeleteUsuario(long id) => repositorio.Delete(id);
    }
}
