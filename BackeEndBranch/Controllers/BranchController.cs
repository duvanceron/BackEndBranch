
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

        public BranchController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Branch>>> Get()
        {
            return await context.Branchs.ToListAsync();

        }
        [HttpGet("{Id:int}")]
        public async Task<ActionResult<Branch>> Get(int id)
        {
            var branch = await context.Branchs.FirstOrDefaultAsync(x => x.CodeBranch == id);
            if (branch == null)
            {
                return NotFound();
            }
            return branch;

        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Branch branch)
        {
            context.Add(branch);
            await context.SaveChangesAsync();
            return NoContent();

        }
     
        [HttpPut("{id:int}")]
        public async Task<ActionResult<Branch>> GPut(int id,[FromBody]  Branch branch)
        {
            var branchExist = await context.Branchs.FirstOrDefaultAsync(x => x.CodeBranch == id);
            if (branchExist == null)
            {
                return NotFound();
            }
            await context.SaveChangesAsync();
            return NoContent();

        }
        [HttpDelete]
        public IEnumerable<Branch> Delete()
        {
            return null;

        }
    }
}
