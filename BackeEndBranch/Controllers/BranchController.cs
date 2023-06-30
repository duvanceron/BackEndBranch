
using BackeEndBranch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace BackeEndBranch.Controllers
{
    [Route("api/branch")]
    [ApiController]
    public class BranchController : ControllerBase
    {
      
        private readonly ApplicationDbContext context;

        public BranchController( ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Branch>>> Get()
        {
            return await context.Branchs.ToListAsync();

        }
 
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Branch branch)
        {
            context.Add(branch);
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
