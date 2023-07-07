
using BackeEndBranch.Interface;
using BackeEndBranch.Models;
using BackeEndBranch.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Xml.Linq;

namespace BackeEndBranch.Controllers
{
    [Route("api/branch")]
    [ApiController]
    public class BranchController : ControllerBase
    {

        private readonly IBranchRepository _branchRepository;

        public BranchController( IBranchRepository branchRepository)
        {
            this._branchRepository = branchRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<Branch>> Get()
        {
            var branchs = await _branchRepository.GetBranchs();
            return branchs;

        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<Branch>> Get(int id)
        {
            var branch = await _branchRepository.GetBranchById(id);
            if (branch == null)
            {
                return NotFound();
            }
            return branch;

        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Branch branch)
        {
            await _branchRepository.InsertBranch(branch);
            return NoContent();

        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Branch>> Put(int id, Branch branch)
        {
            var branchExist = await _branchRepository.ExistBranch(id);

            if (branchExist == false)
            {
                return NotFound();
            }
            branch.CodeBranch = id;
            await _branchRepository.UpdateBranch(branch);
            return NoContent();

        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Branch>> Delete(int id)
        {
            var existRow = await _branchRepository.ExistBranch(id);
            if (existRow == false)
            {
                return NotFound();
            }
            await _branchRepository.DeleteBranch(new Branch() { CodeBranch = id });
            return NoContent();


        }
    }
}
