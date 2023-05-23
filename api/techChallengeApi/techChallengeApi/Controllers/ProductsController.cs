using Microsoft.AspNetCore.Mvc;
using techChallengeApi.Model;
using techChallengeApi.Repositories.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace techChallengeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/<ProductsController>
        private readonly IProducts _products;

        public ProductsController(IProducts products)
        {
            _products = products;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<ActionResult<List<Products>>> GetAllProducts()
        {
            List<Products> result = await _products.GetAllProducts();
            return Ok(result);
        }
       

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Products>> GetProductsByID(int id)
        {
            Products products = await _products.GetProductsById(id);
            return Ok(products);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<ActionResult<Products>> PostProducts([FromBody] Products products)
        {
            Products result = await _products.AddProducts(products);
            return Ok(result);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Products>> UpdateProducts(int id, [FromBody] Products products)
        {
            products.Id = id;
            Products result = await _products.AddProducts(products);
            return Ok(result);
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Products>> DeleteProducts(int id)
        {
            bool deleted = await _products.DeleteProducts(id);
            return Ok(deleted);
        }
    }
}
