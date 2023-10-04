using citas_medicas.Entities;
using citas_medicas.Repositories;

namespace citas_medicas.Services.Implements
{
    public class DiagnosticoService : IDiagnosticoService
    {

        private DiagnosticoRepository repositorio;

        public DiagnosticoService(DiagnosticoRepository diagnosticoRepository)
        {
            repositorio = diagnosticoRepository;
        }

        public List<Diagnostico> GetAllDiagnosticos() => repositorio.GetAll();
        public Diagnostico GetDiagnosticoById(long id) => repositorio.GetById(id);
        public Diagnostico AddDiagnostico(Diagnostico nuevoDiagnostico) => repositorio.Add(nuevoDiagnostico);
        public Diagnostico DeleteDiagnostico(long id) => repositorio.Delete(id);
    }
}
