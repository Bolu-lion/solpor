using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolutionPortalBeta.Server.Models;
using SolutionPortalBeta.Server.Service;
using System;

namespace SolutionPortalBeta.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaqController : ControllerBase
    {
        private readonly IFaqService _faqService;
        public FaqController(IFaqService faqService)
        {
            _faqService = faqService;
        }
        [HttpGet]
        public async Task<List<FAQ>> GetAll()
        {
            return await _faqService.GetAllFAQs();
        }
        [HttpGet("{id}")]
        public async Task<FAQ> Get(int id)
        {
            return await _faqService.GetFAQ(id);
        }
        [HttpPost]
        public async Task<FAQ> AddPerson([FromBody] FAQ person)
        {
            return await _faqService.AddFAQ(person);
        }
        [HttpDelete("{id}")]
        public async Task<bool> DeleteFAQ(int id)
        {
            await _faqService.DeleteFAQ(id);
            return true;
        }
        [HttpPut("{id}")]
        public async Task<bool> UpdateFAQ(int id, [FromBody] FAQ Object)
        {
            await _faqService.UpdateFAQ(id, Object);
            return true;
        }
    }
}
