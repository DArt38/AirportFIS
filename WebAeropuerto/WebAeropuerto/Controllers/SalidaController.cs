using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAeropuerto.Data.Repositories;
using WebAeropuerto.Model;

namespace WebAeropuerto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalidaController : ControllerBase
    {
        private readonly ISalidaRepository _salidaRepository;

        public SalidaController(SalidaRepository salidaRepository)
        {
            _salidaRepository = salidaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSalida()
        {
            return Ok(await _salidaRepository.GetAllSalidas());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSalidaDetails(int id)
        {
            return Ok(await _salidaRepository.GetSalidaDetails(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateSalida([FromBody] Salida salida)
        {
            if (salida == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var created = await _salidaRepository.InsertSalida(salida);

            return Created("created", created);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSalida([FromBody] Salida salida)
        {
            if (salida == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _salidaRepository.InsertSalida(salida);

            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSalida(int id)
        {
            await _salidaRepository.DeleteSalida(new Salida { Id = id });

            return NoContent();
        }

    }
}
