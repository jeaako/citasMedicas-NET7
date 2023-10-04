using citas_medicas.Entities;
using citas_medicas.Repositories;

namespace citas_medicas.Services.Implements
{
    public class PacienteService : IPacienteService
    {
        private PacienteRepository repositorio;

        public PacienteService(PacienteRepository pacienteRepository)
        {
            repositorio = pacienteRepository;
        }

        public List<Paciente> GetAllPacientes() => repositorio.GetAll();
        public Paciente GetPacienteById(long id) => repositorio.GetById(id);
        public Paciente AddPaciente(Paciente nuevoPaciente) => repositorio.Add(nuevoPaciente);
        public Paciente DeletePaciente(long id) => repositorio.Delete(id);
    }
}
