using System.ComponentModel.DataAnnotations;

namespace citas_medicas.Entities

{
    public class Cita : IEntity
    {
        [Key]
        [Required]
        public long Id { get; set; }
        
        [Required]
        public string MotivoCita { get; set; } = string.Empty;
        
        [Required]
        public DateTime FechaHora { get; set; }
        
        [Required]
        public required Diagnostico Diagnostico { get; set; }     
        
        //[Required]
        //public required Medico Medico { get; set; }
        
        //[Required]
        //public required Paciente Paciente { get; set; }
    }
}
