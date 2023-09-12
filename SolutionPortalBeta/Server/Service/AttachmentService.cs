using SolutionPortalBeta.Server.Models;
using SolutionPortalBeta.Server.Repository;

namespace SolutionPortalBeta.Server.Service
{
    public class AttachmentService : IAttachmentService
    {
        private readonly IAttachmentRepository<Attachment> _attachment;

        public AttachmentService(IAttachmentRepository<Attachment> attachment){
            _attachment = attachment;
        } 
        public async Task<Attachment> AddAttachment(Attachment attachment)
        {
            return await _attachment.CreateAsync (attachment);
        }

        public async Task<List<Attachment>> GetAllAttachments()
        {
            return await _attachment.GetAllAsync();
        }

        public async Task<Attachment> GetAttachment(int id)
        {
            return await _attachment.GetByIdAsync(id);
        }

        public async Task<List<Attachment>> GetAttachmentByCompliantId(int ComplaintId)
        {
            return await _attachment.GetByComplaintId(ComplaintId);
        }
    }
}