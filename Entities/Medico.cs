using System.ComponentModel.DataAnnotations;

namespace citas_medicas.Entities
{
    public class Medico : Usuario
    {
        [Required]
        public String NumColegiado { get; set; } = string.Empty;
        
        [Required]
        public ICollection<Paciente> Pacientes { get; set; } = new List<Paciente>();

        [Required]
        public ICollection<Cita> Citas { get; set; } = new List<Cita>();
    }
}
