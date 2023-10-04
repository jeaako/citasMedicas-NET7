using citas_medicas.Entities;

namespace citas_medicas.Services
{
    public interface IDiagnosticoService
    {
        public List<Diagnostico> GetAllDiagnosticos();
        public Diagnostico GetDiagnosticoById(long id);
        public Diagnostico AddDiagnostico(Diagnostico nuevoDiagnostico);
        public Diagnostico DeleteDiagnostico(long id);
    }
}
