using Microsoft.EntityFrameworkCore;
using SolutionPortalBeta.Server.AppDbContext;
using SolutionPortalBeta.Server.Models;

namespace SolutionPortalBeta.Server.Repository
{
    public class CompanyRepository : ICompanyRepository<Company>
    {
        ApplicationDbContext _dbContext;
        public CompanyRepository(ApplicationDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public async Task<Company> CreateAsync(Company _object)
        {
            var obj = await _dbContext.Companies.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            var data = _dbContext.Companies.FirstOrDefault(x => x.id == id);
            _dbContext.Remove(data);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Company>> GetAllAsync()
        {
            return await _dbContext.Companies.ToListAsync();
        }

        public async Task<Company> GetByIdAsync(int Id)
        {
            return await _dbContext.Companies.FirstOrDefaultAsync(x => x.id == Id);
        }

        public async Task UpdateAsync(Company _object)
        {
            _dbContext.Companies.Update(_object);
            await _dbContext.SaveChangesAsync();
        }
    }
}
