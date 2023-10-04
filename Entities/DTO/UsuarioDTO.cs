namespace citas_medicas.Models.DTO
{
    public class UsuarioDTO
    {
        public long Id { get; set; }
        public String Nombre { get; set; } = string.Empty;
        public String Apellidos { get; set; } = string.Empty;
        public String Username { get; set; } = string.Empty;
        public String Clave { get; set; } = string.Empty;
    }
}
