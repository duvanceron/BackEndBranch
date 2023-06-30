
using BackeEndBranch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace BackeEndBranch.Controllers
{
    [Route("api/coin")]
    [ApiController]
    public class CoinController : ControllerBase
    {

        private readonly ApplicationDbContext context;

        public CoinController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Coin>>> Get()
        {
            return await context.Coins.ToListAsync();

        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Coin coin)
        {
            context.Add(coin);
            await context.SaveChangesAsync();
            return NoContent();

        }
        [HttpPut]
        public IEnumerable<Branch> Put()
        {
            return null;

        }
        [HttpDelete]
        public IEnumerable<Branch> Delete()
        {
            return null;

        }
    }
}
