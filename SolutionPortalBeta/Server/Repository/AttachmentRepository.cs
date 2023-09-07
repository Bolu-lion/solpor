using Microsoft.EntityFrameworkCore;
using SolutionPortalBeta.Server.AppDbContext;
using SolutionPortalBeta.Server.Models;

namespace SolutionPortalBeta.Server.Repository
{
    public class AttachmentRepository : IAttachmentRepository<Attachment>
    {
        ApplicationDbContext _dbContext;

        public AttachmentRepository(ApplicationDbContext dbContext){
            _dbContext = dbContext;
        }
        public async Task<Attachment> CreateAsync(Attachment _object)
        {
           var obj = await _dbContext.Attachments.AddAsync(_object);
			_dbContext.SaveChanges();
			return obj.Entity;
        }

        public async Task<List<Attachment>> GetAllAsync()
        {
            return await _dbContext.Attachments.ToListAsync();
        }

        public async Task<List<Attachment>> GetByComplaintId(int ComplaintId)
        {
            return await _dbContext.Attachments.Where(y => y.ComplaintId == ComplaintId).ToListAsync();
        }

        public async Task<Attachment> GetByIdAsync(int Id)
        {
            return await _dbContext.Attachments.FirstOrDefaultAsync(x => x.AttachmentId == Id);
        }
    }
}