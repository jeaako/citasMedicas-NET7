namespace citas_medicas.Models.DTO
{
    public class DiagnosticoDTO
    {
        public long Id { get; set; }
        public string ValoracionEspecialista { get; set; } = string.Empty;
        public string Enfermedad { get; set; } = string.Empty;
    }
}
