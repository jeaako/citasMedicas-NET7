using AutoMapper;
using citas_medicas.Entities;
using citas_medicas.Models.DTO;
using citas_medicas.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace citas_medicas.Controllers
{
    [Route("diagnosticos")]
    [ApiController]
    public class DiagnosticoController : ControllerBase
    {
        private readonly IDiagnosticoService _diagnosticoService;
        private readonly IMapper _mapper;

        public DiagnosticoController(IDiagnosticoService diagnosticoService, IMapper mapper)
        {
            _diagnosticoService = diagnosticoService;
            _mapper = mapper;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<DiagnosticoDTO>> GetDiagnosticos()
        {
            IList<DiagnosticoDTO> DiagnosticosDTO = new List<DiagnosticoDTO>();
            var diagnosticos = _diagnosticoService.GetAllDiagnosticos();
            
            foreach (Diagnostico u in diagnosticos)
                DiagnosticosDTO.Add(_mapper.Map<DiagnosticoDTO>(u));

            return Ok(DiagnosticosDTO.ToList());
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<DiagnosticoDTO> GetDiagnosticoById(long id)
        {
            var diagnostico = _diagnosticoService.GetDiagnosticoById(id);

            if (diagnostico != null)
                return _mapper.Map<DiagnosticoDTO>(diagnostico);

            return NotFound();

        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<String> AddDiagnostico(DiagnosticoDTO diagnosticoDTO)
        {
            if (_diagnosticoService.AddDiagnostico(_mapper.Map<Diagnostico>(diagnosticoDTO)) != null)
                return Ok("Diagnostico creado correctamente.");

            return BadRequest();
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult<String> DeleteDiagnostico(long id)
        {
            if (_diagnosticoService.DeleteDiagnostico(id) != null)
                return Ok("Diagnostico eliminado correctamente");

            return NotFound();
        }


    }
}
