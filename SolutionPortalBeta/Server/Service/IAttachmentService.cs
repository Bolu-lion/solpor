<<<<<<< HEAD
﻿using SolutionPortalBeta.Server.Models;

namespace SolutionPortalBeta.Server.Service
{
    public interface IAttachmentService
    {
        Task<Attachment> AddAttachment(Department department);
    }
}
=======
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
>>>>>>> 241927f21aef3b36d3abe4f3325001cad224097e
