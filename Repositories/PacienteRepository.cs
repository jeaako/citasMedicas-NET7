using citas_medicas.Entities;

namespace citas_medicas.Repositories
{
    public class PacienteRepository: EFCoreRepository<Paciente, CMContext>
    {
        public PacienteRepository(CMContext context) : base(context) 
        {
        }
    }
}
