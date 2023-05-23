using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using techChallengeApi.Model;
using techChallengeApi.Repositories.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace techChallengeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private readonly ISeller _seller;

        public SellerController(ISeller seller)
        {
            _seller = seller;
        }

        // GET: api/<SellerController>
        [HttpGet]
        public async Task<ActionResult<List<Seller>>> GetAllSeller()
        {
            List<Seller> result = await _seller.GetAllSellers();
            return Ok(result);
        }

        // GET api/<SellerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Seller>> GetSellersByID(int id)
        {
            Seller sellerById = await _seller.GetSellerById(id);
            return Ok(sellerById);
        }
        

        // POST api/<SellerController>
        [HttpPost]
        public async Task<ActionResult<Seller>> PostSeller([FromBody] Seller seller)
        {
            Seller result = await _seller.AddSeller(seller);
            return Ok(result);
        }

        // PUT api/<SellerController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Seller>> UpdateSeller(int id, [FromBody] Seller seller)
        {
            seller.Id = id;
            Seller result = await _seller.AddSeller(seller);
            return Ok(result);
        }

        // DELETE api/<SellerController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Seller>> DeleteSeller(int id)
        {
            bool deleted = await _seller.DeleteSeller(id);
            return Ok(deleted);
        }
    }
}
