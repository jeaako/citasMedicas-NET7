namespace citas_medicas.Entities
{
    public class MedicoPaciente
    {
        public long PacienteId { get; set; }
        public long MedicoId { get; set; }
        public required Medico Medico { get; set; }
        public required Paciente Paciente { get; set; }
      
    }
}
