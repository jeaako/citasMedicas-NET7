using citas_medicas.Entities;

namespace citas_medicas.Services
{
    public interface IUsuarioService
    {
        public List<Usuario> GetAllUsuarios();
        public Usuario GetUsuarioById(long id);
        public Usuario AddUsuario(Usuario nuevoUsuario);
        public Usuario DeleteUsuario(long id);
    }
}
