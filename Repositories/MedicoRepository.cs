using citas_medicas.Entities;

namespace citas_medicas.Repositories
{
    public class MedicoRepository: EFCoreRepository<Medico, CMContext>
    {
        public MedicoRepository(CMContext context) : base(context) 
        {
        }
    }
}
