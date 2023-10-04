using System.ComponentModel.DataAnnotations;

namespace citas_medicas.Entities
{
    public class Paciente : Usuario {
		
		[Required]
		public String NSS { get; set; } = string.Empty;

		[Required]
		public String NumTarjeta { get; set; } = string.Empty;

		[Required]
		public String Telefono { get; set; } = string.Empty;

		[Required]
		public String Direccion { get; set; } = string.Empty;

		[Required]
		public ICollection<Medico> Medicos { get; set; } = new List<Medico>();

        [Required]
        public ICollection<Cita> Citas { get; set; } = new List<Cita>();
    }
}
