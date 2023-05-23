using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using techChallengeApi.Model;
using techChallengeApi.Repositories.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace techChallengeApi.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralSalesController : ControllerBase
    {
        private readonly IGeneralSales _generalSales;

        public GeneralSalesController(IGeneralSales generalSales)
        {
            _generalSales = generalSales;
        }

        // GET: api/<GeneralSalesController>
        [HttpGet]
        public async Task<ActionResult<List<GeneralSales>>> GetAllGeneralSales()
        {
            List<GeneralSales> result = await _generalSales.GetAllProducts();
            
            return Ok(result);
        }
        

        // GET api/<GeneralSalesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GeneralSales>> GetGeneralSalesByID(int id)
        {
            GeneralSales generalSales = await _generalSales.GetGeneralSalesById(id);
            return Ok(generalSales);
        }

        // POST api/<GeneralSalesController>
        [HttpPost]
        public async Task<ActionResult<GeneralSales>> PostGeneralSales([FromBody] GeneralSales generalSales)
        {
            GeneralSales result = await _generalSales.AddGeneralSales(generalSales);
            return Ok(result);
        }

        // PUT api/<GeneralSalesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<GeneralSales>> UpdateGeneralSales(int id, [FromBody] GeneralSales generalSales)
        {
            generalSales.Id = id;
            GeneralSales result = await _generalSales.AddGeneralSales(generalSales);
            return Ok(result);
        }

        // DELETE api/<GeneralSalesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GeneralSales>> DeleteGeneralSales(int id)
        {
            bool deleted = await _generalSales.DeleteGeneralSales(id);
            return Ok(deleted);
        }
    }
}
