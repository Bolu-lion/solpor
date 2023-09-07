using SolutionPortalBeta.Server.Models;

namespace  SolutionPortalBeta.Server.Service
{
    public interface IAttachmentService
    {
        Task<Attachment> AddAttachment (Attachment attachment);
		Task<List<Attachment>> GetAllAttachments();
		Task<Attachment> GetAttachment(int id);
		Task<List<Attachment>> GetAttachmentByCompliantId(int ComplaintId);
    }
}