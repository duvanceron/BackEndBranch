
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

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Coin>> Put(int id, Coin coin)
        {
            var coinExist = await context.Coins.FirstOrDefaultAsync(x => x.IdCoin == id);

            if (coinExist == null)
            {
                return NotFound();
            }
            coin.IdCoin = coinExist.IdCoin;
            context.ChangeTracker.Clear();
            context.Update(coin);
            await context.SaveChangesAsync();
            return NoContent();
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Coin>> Delete(int id)
        {
            context.ChangeTracker.Clear();
            var existRow = await context.Coins.FirstOrDefaultAsync(x => x.IdCoin == id);
            if (existRow == null)
            {
                return NotFound();
            }
            context.ChangeTracker.Clear();
            context.Remove(new Coin() { IdCoin = id });
            await context.SaveChangesAsync();
            return NoContent();


        }
    }
}
