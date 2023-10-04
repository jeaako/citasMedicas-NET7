namespace citas_medicas.Models.DTO
{
    public class PacienteDTO
    {
        public long Id { get; set; }
        public String Nombre { get; set; } = string.Empty;
        public String Apellidos { get; set; } = string.Empty;
        public String Username { get; set; } = string.Empty;
        public String Clave { get; set; } = string.Empty;
        public String NSS { get; set; } = string.Empty;
        public String NumTarjeta { get; set; } = string.Empty;
        public String Telefono { get; set; } = string.Empty;
        public String Direccion { get; set; } = string.Empty;
        public List<long> Medicos { get; set; } = new List<long>();
        public List<long> Citas { get; set; } = new List<long>();
    }
}
