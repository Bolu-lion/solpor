using SolutionPortalBeta.Server.Models;
using System;

namespace SolutionPortalBeta.Server.Service
{
    public interface IFaqService
    {
        Task<FAQ> AddFAQ(FAQ person);
        Task<bool> UpdateFAQ(int id, FAQ person);
        Task<bool> DeleteFAQ(int id);
        Task<List<FAQ>> GetAllFAQs();
        Task<FAQ> GetFAQ(int id);
    }
}
