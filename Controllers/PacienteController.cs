using AutoMapper;
using citas_medicas.Entities;
using citas_medicas.Models.DTO;
using citas_medicas.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace citas_medicas.Controllers
{
    [Route("pacientes")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteService _pacienteService;
        private readonly IMapper _mapper;

        public PacienteController(IPacienteService PacienteService, IMapper mapper)
        {
            _pacienteService = PacienteService;
            _mapper = mapper;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<PacienteDTO>> GetPacientes()
        {
            IList<PacienteDTO> PacientesDTO = new List<PacienteDTO>();
            var pacientes = _pacienteService.GetAllPacientes();
           
            foreach (Paciente p in pacientes)
                PacientesDTO.Add(_mapper.Map<PacienteDTO>(p));

            return Ok(PacientesDTO.ToList());
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<PacienteDTO> GetPacienteById(long id)
        {
            var Paciente = _pacienteService.GetPacienteById(id);

            if (Paciente != null)
                return _mapper.Map<PacienteDTO>(Paciente);

            return NotFound();
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<String> AddPaciente(PacienteDTO pacienteDTO)
        {
            if (_pacienteService.AddPaciente(_mapper.Map<Paciente>(pacienteDTO)) != null)
                return Ok("Paciente creado correctamente.");

            return BadRequest();
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult<String> DeletePaciente(long id)
        {
            if (_pacienteService.DeletePaciente(id) != null)
                return Ok("Paciente eliminado correctamente");

            return NotFound();
        }
    }
}
