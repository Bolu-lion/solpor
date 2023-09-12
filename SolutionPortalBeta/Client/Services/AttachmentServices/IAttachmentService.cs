using SolutionPortalBeta.Shared;

namespace SolutionPortalBeta.Client.Services.AttachmentServices
{
    public interface IAttachmentService
    {
        Task<AttachementModel> AddAttachment(AttachementModel attachment);
        Task<List<AttachementModel>> GetAllAttachments();
        Task<AttachementModel> GetAttachment(int id);
        Task<List<AttachementModel>> GetAttachmentByCompliantId(int ComplaintId);
    }
}