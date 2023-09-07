using SolutionPortalBeta.Server.Models;

namespace SolutionPortalBeta.Server.Service
{
    public interface IAttachmentService
    {
        Task<Attachment> AddAttachment(Department department);
    }
}
