using BackeEndBranch.Interface;
using BackeEndBranch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace BackeEndBranch.Repository
{
    public class BranchRepository : IBranchRepository

    {
        private readonly ApplicationDbContext context;
        public BranchRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> ExistBranch(int id)
        {
            return await context.Branchs.FirstOrDefaultAsync(x => x.CodeBranch == id) != null ? true : false;
        }

        public async Task<Branch> GetBranchById(int branchId)
        {

            return await context.Branchs.Where(x => x.CodeBranch == branchId).FirstAsync();
        }

        public async Task<IEnumerable<Branch>> GetBranchs()
        {
            return await context.Branchs.ToListAsync();
        }

        public async Task InsertBranch(Branch branch)
        {
            context.Add(branch);
            await context.SaveChangesAsync();
        }

        public async Task UpdateBranch(Branch branch)
        {
            context.ChangeTracker.Clear();
            context.Update(branch);
            await context.SaveChangesAsync();
        }
        public async Task DeleteBranch(Branch branch)
        {
            context.ChangeTracker.Clear();
            context.Remove(branch);
            await context.SaveChangesAsync();
        }



    }
}
