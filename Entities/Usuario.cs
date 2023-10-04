using System.ComponentModel.DataAnnotations;

namespace citas_medicas.Entities
{
    public class Usuario : IEntity
    {
        [Key]
        [Required]
        public long Id { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        public string Apellidos { get; set; } = string.Empty;

        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string Clave { get; set; } = string.Empty;
    }
}
