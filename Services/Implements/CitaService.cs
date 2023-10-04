using citas_medicas.Entities;
using citas_medicas.Repositories;

namespace citas_medicas.Services.Implements
{
    public class CitaService : ICitaService
    {

        private CitaRepository repositorio;

        public CitaService(CitaRepository citaRepository)
        {
            repositorio = citaRepository;
        }

        public List<Cita> GetAllCitas() => repositorio.GetAll();
        public Cita GetCitaById(long id) => repositorio.GetById(id);
        public Cita AddCita(Cita nuevoCita) => repositorio.Add(nuevoCita);
        public Cita DeleteCita(long id) => repositorio.Delete(id);
    }
}
