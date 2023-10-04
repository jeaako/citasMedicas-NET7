using citas_medicas.Entities;

namespace citas_medicas.Repositories
{
    public class UsuarioRepository : EFCoreRepository<Usuario, CMContext>
    {
        public UsuarioRepository(CMContext context) : base(context) 
        {
        }
    }
}
