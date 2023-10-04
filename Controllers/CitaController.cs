using AutoMapper;
using citas_medicas.Entities;
using citas_medicas.Models.DTO;
using citas_medicas.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace citas_medicas.Controllers
{
    [Route("citas")]
    [ApiController]
    public class CitaController : ControllerBase
    {
        private readonly ICitaService _citaService;
        private readonly IMapper _mapper;


        public CitaController(ICitaService citaService, IMapper mapper)
        {
            _citaService = citaService;
            _mapper = mapper;
        }

        /// <summary>
        /// Obtiene todos los elementos.
        /// </summary>
        /// <returns>Una lista de elementos.</returns>
        [HttpGet]
        public ActionResult<List<CitaDTO>> GetCitas()
        {
            IList<CitaDTO> CitasDTO = new List<CitaDTO>();
            var citas = _citaService.GetAllCitas();
            
            foreach (Cita u in citas)
                CitasDTO.Add(_mapper.Map<CitaDTO>(u));

            return Ok(CitasDTO.ToList());
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<CitaDTO> GetCitaById(long id)
        {
            var cita = _citaService.GetCitaById(id);

            if (cita != null)
                return _mapper.Map<CitaDTO>(cita);

            return NotFound();

        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<String> AddCita(CitaDTO citaDTO)
        {
            if (_citaService.AddCita(_mapper.Map<Cita>(citaDTO)) != null)
                return Ok("Cita creado correctamente.");

            return BadRequest();
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult<String> DeleteCita(long id)
        {
            if (_citaService.DeleteCita(id) != null)
                return Ok("Cita eliminado correctamente");

            return NotFound();
        }


    }
}
