namespace citas_medicas.Models.DTO
{
    public class CitaDTO
    {
        public long Id { get; set; }
        public string MotivoCita { get; set; } = string.Empty;
        public string FechaHora { get; set; } = string.Empty;
        public long Diagnostico { get; set; }
        public long Medico { get; set; }
        public long Paciente { get; set; }
    }
}
