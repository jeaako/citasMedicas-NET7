using citas_medicas.Entities;

namespace citas_medicas.Services
{
    public interface IMedicoService
    {
        public List<Medico> GetAllMedicos();
        public Medico GetMedicoById(long id);
        public Medico AddMedico(Medico nuevoMedico);
        public Medico DeleteMedico(long id);
    }
}
