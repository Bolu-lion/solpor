using SolutionPortalBeta.Server.Models;

namespace SolutionPortalBeta.Server.Repository
{
	public interface IAttachmentRepository<T>
	{
		public Task<Attachment> CreateAsync(T _object);
		public Task<List<Attachment>> GetAllAsync();
		public Task<Attachment> GetByIdAsync(int Id);
        public Task<List<Attachment>> GetByComplaintId(int Id);

    }
}
