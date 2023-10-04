namespace citas_medicas.Models.DTO
{
    public class MedicoDTO
    {
        public long Id { get; set; }
        public String Nombre { get; set; } = string.Empty;
        public String Apellidos { get; set; } = string.Empty;
        public String Username { get; set; } = string.Empty;
        public String Clave { get; set; } = string.Empty;
        public String NumColegiado { get; set; } = string.Empty;
        public List<long> Pacientes { get; set; } = new List<long>();
        public List<long> Citas { get; set; } = new List<long>();
    }
}
