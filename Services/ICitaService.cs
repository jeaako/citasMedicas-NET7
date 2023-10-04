using citas_medicas.Entities;

namespace citas_medicas.Services
{
    public interface ICitaService
    {
        public List<Cita> GetAllCitas();
        public Cita GetCitaById(long id);
        public Cita AddCita(Cita nuevoCita);
        public Cita DeleteCita(long id);
    }
}
