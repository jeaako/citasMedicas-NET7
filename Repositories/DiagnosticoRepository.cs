using citas_medicas.Entities;

namespace citas_medicas.Repositories
{
    public class DiagnosticoRepository : EFCoreRepository<Diagnostico, CMContext>
    {
        public DiagnosticoRepository(CMContext context) : base(context) 
        {
        }
    }
}
