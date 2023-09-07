using Microsoft.AspNetCore.Mvc;
using SolutionPortalBeta.Server.Models;
using SolutionPortalBeta.Server.Service;

namespace SolutionPortalBeta.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttachmentController : ControllerBase
    {
        private readonly IAttachmentService _attachment;

        public AttachmentController(IAttachmentService attachment){
            _attachment = attachment;
        }

        [HttpGet]
        public async Task<List<Attachment>>GetAll(){
            return await  _attachment.GetAllAttachments();
        }

        [HttpGet("{id}")]
        public async Task<Attachment> Get(int id)
        {
            return await _attachment.GetAttachment(id);
        }

        [HttpPost]
        public async Task<Attachment> AddAttachment([FromBody] Attachment attachment){
            return await _attachment.AddAttachment(attachment);
        }

        [HttpGet("{Id}")]
        public async Task<List<Attachment>> GetByComplaintId(int Id){
            return await _attachment.GetAttachmentByCompliantId(Id);
        }
    }
}