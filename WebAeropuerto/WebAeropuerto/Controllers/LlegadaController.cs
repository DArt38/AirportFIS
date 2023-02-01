using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAeropuerto.Data.Repositories;
using WebAeropuerto.Model;

namespace WebAeropuerto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LlegadaController : ControllerBase
    {
        private readonly ILlegadaRepository _llegadaRepository;


        public LlegadaController(ILlegadaRepository llegadaRepository)
        {
            _llegadaRepository = llegadaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLLegada()
        {
            return Ok(await _llegadaRepository.GetAllLlegadas());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLlegadaDetails(int id)
        {
            return Ok(await _llegadaRepository.GetDetails(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateLlegada([FromBody] Llegada llegada)
        {
            if (llegada == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var created = await _llegadaRepository.InsertLlegada(llegada);

            return Created("created", created);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateLlegada([FromBody] Llegada llegada)
        {   
           if (llegada == null)
                return BadRequest();
           
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _llegadaRepository.UpdateLlegada(llegada);
            
          
            return NoContent();
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteLlegada(int id)
        {
            await _llegadaRepository.DeleteLlegada(new Llegada { Id = id});

            return NoContent();
        }
    }
}
