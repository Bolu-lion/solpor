using SolutionPortalBeta.Server.Models;
using SolutionPortalBeta.Server.Repository;
using System;

namespace SolutionPortalBeta.Server.Service
{
    public class FaqService : IFaqService
    {
        private readonly IFaqRepository<FAQ> _faq;
        public FaqService(IFaqRepository<FAQ> faq)
        {
            _faq = faq;
        }
        public async Task<FAQ> AddFAQ(FAQ faq)
        {
            return await _faq.CreateAsync(faq);
        }

        public async Task<bool> DeleteFAQ(int id)
        {
            await _faq.DeleteAsync(id);
            return true;
        }

        public async Task<List<FAQ>> GetAllFAQs()
        {
            return await _faq.GetAllAsync();
        }

        public async Task<FAQ> GetFAQ(int id)
        {
            return await _faq.GetByIdAsync(id);
        }

        public async Task<bool> UpdateFAQ(int id, FAQ faq)
        {
            var data = await _faq.GetByIdAsync(id);
            if (data != null)
            {
                data.Title = faq.Title;
                data.Description = faq.Description;
                data.Content = faq.Content;
                await _faq.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }
    }
}
