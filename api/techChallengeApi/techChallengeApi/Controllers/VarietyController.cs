using Microsoft.AspNetCore.Mvc;
using techChallengeApi.Model;
using techChallengeApi.Repositories.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace techChallengeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VarietyController : ControllerBase
    {
        // GET: api/<VarietyController>
        private readonly IVariety _variety;

        public VarietyController(IVariety variety)
        {
            _variety = variety;
        }

        // GET: api/<VarietyController>
        [HttpGet]
        public async Task<ActionResult<List<Variety>>> GetAllVariety()
        {
            List<Variety> result = await _variety.GetAllVariety();
            return Ok(result);
        }
        

        // GET api/<VarietyController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Variety>> GetVarietyByID(int id)
        {
            Variety variety = await _variety.GetVarietyById(id);
            return Ok(variety);
        }

        // POST api/<VarietyController>
        [HttpPost]
        public async Task<ActionResult<Variety>> PostVariety([FromBody] Variety variety)
        {
            Variety result = await _variety.AddVariety(variety);
            return Ok(result);
        }

        // PUT api/<VarietyController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Variety>> UpdateVariety(int id, [FromBody] Variety variety)
        {
            variety.Id = id;
            Variety result = await _variety.AddVariety(variety);
            return Ok(result);
        }

        // DELETE api/<VarietyController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Variety>> DeleteVariety(int id)
        {
            bool deleted = await _variety.DeleteVariety(id);
            return Ok(deleted);
        }
    }
}
