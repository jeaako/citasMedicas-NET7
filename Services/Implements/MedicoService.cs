using citas_medicas.Entities;
using citas_medicas.Repositories;

namespace citas_medicas.Services.Implements
{
    public class MedicoService : IMedicoService
    {
        private MedicoRepository repositorio;

        public MedicoService(MedicoRepository medicoRepository)
        {
            repositorio = medicoRepository;
        }

        public List<Medico> GetAllMedicos() => repositorio.GetAll();
        public Medico GetMedicoById(long id) => repositorio.GetById(id);
        public Medico AddMedico(Medico nuevoMedico) => repositorio.Add(nuevoMedico);
        public Medico DeleteMedico(long id) => repositorio.Delete(id);
    }
}
