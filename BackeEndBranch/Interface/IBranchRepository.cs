using BackeEndBranch.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackeEndBranch.Interface
{
    public interface IBranchRepository 
    {
      
        Task<bool> ExistBranch(int id);
        Task<Branch> GetBranchById(int branchId);
        Task<IEnumerable<Branch>> GetBranchs();
        Task InsertBranch(Branch branch);
        Task UpdateBranch(Branch branch);
        Task DeleteBranch(Branch branch);
    }
}
