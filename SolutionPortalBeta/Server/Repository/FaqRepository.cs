using Microsoft.EntityFrameworkCore;
using SolutionPortalBeta.Server.AppDbContext;
using SolutionPortalBeta.Server.Models;
using System;

namespace SolutionPortalBeta.Server.Repository
{
    public class FaqRepository : IFaqRepository<FAQ>
    {
        ApplicationDbContext _dbContext;
        public FaqRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<FAQ> CreateAsync(FAQ _object)
        {
            var obj = await _dbContext.FAQs.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public async Task DeleteAsync(int Id)
        {
            var data = _dbContext.FAQs.FirstOrDefault(x => x.Id == Id);
            _dbContext.Remove(data);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<FAQ>> GetAllAsync()
        {
            return await _dbContext.FAQs.ToListAsync();
        }

        public async Task<FAQ> GetByIdAsync(int Id)
        {
            return await _dbContext.FAQs.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task UpdateAsync(FAQ _object)
        {
            _dbContext.FAQs.Update(_object);
            await _dbContext.SaveChangesAsync();
        }

    }
}
