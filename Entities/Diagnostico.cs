using System.ComponentModel.DataAnnotations;

namespace citas_medicas.Entities
{
    public class Diagnostico : IEntity
    {
        [Key]
        [Required]
        public long Id { get; set; }

        [Required]
        public string ValoracionEspecialista { get; set; } = string.Empty;

        [Required]
        public string Enfermedad { get; set; } = string.Empty;
    }
}
