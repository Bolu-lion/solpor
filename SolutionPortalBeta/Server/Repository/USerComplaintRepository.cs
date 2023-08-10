
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SolutionPortalBeta.Server.AppDbContext;
using SolutionPortalBeta.Server.Models;

namespace SolutionPortalBeta.Server.Repository
{
	public class USerComplaintRepository : IRepository<UserComplaint>
	{
		ApplicationDbContext _dbcontext;
		public USerComplaintRepository(ApplicationDbContext dbcontext)
		{
			_dbcontext = dbcontext;
		}

		public async Task<UserComplaint> CreateAsync(UserComplaint _object)
		{
			var obj = await _dbcontext.UserComplaints.AddAsync(_object);
			_dbcontext.SaveChanges();
			return obj.Entity;
		}

		public async Task<List<UserComplaint>> GetAllAsync()
		{
			return await _dbcontext.UserComplaints.ToListAsync();
		}

        public async Task<List<UserComplaint>> GetByDateAsync(DateTime date)
        {
            return await _dbcontext.UserComplaints.Where(y => y.DateCreated == date).ToListAsync();
        }

        public async Task<UserComplaint> GetByIdAsync(int Id)
		{
			return await _dbcontext.UserComplaints.FirstOrDefaultAsync(x => x.Id == Id);
		}

         
    }
}
