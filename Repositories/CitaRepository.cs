using citas_medicas.Entities;

namespace citas_medicas.Repositories
{
    public class CitaRepository : EFCoreRepository<Cita, CMContext>
    {
        public CitaRepository(CMContext context) : base(context) 
        {
        }
    }
}
