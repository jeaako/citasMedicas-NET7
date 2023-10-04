using citas_medicas.Entities;

namespace citas_medicas.Services
{
    public interface IPacienteService
    {
        public List<Paciente> GetAllPacientes();
        public Paciente GetPacienteById(long id);
        public Paciente AddPaciente(Paciente nuevoPaciente);
        public Paciente DeletePaciente(long id);
    }
}
