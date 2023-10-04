using AutoMapper;
using citas_medicas.Entities;
using citas_medicas.Models.DTO;
using citas_medicas.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace citas_medicas.Controllers
{
    [Route("medicos")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly IMedicoService _medicoService;
        private readonly IMapper _mapper;

        public MedicoController(IMedicoService medicoService, IMapper mapper)
        {
            _medicoService = medicoService;
            _mapper = mapper;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<MedicoDTO>> GetMedicos()
        {
            IList<MedicoDTO> MedicosDTO = new List<MedicoDTO>();
            var medicos = _medicoService.GetAllMedicos();
            
            foreach (Medico u in medicos)
                MedicosDTO.Add(_mapper.Map<MedicoDTO>(u));

            return Ok(MedicosDTO.ToList());
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<MedicoDTO> GetMedicoById(long id)
        {
            var medico = _medicoService.GetMedicoById(id);

            if (medico != null)
                return _mapper.Map<MedicoDTO>(medico);

            return NotFound();

        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<String> AddMedico(MedicoDTO medicoDTO)
        {
            if (_medicoService.AddMedico(_mapper.Map<Medico>(medicoDTO)) != null)
                return Ok("Medico creado correctamente.");

            return BadRequest();
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult<String> DeleteMedico(long id)
        {
            if (_medicoService.DeleteMedico(id) != null)
                return Ok("Medico eliminado correctamente");

            return NotFound();
        }
    }
}
