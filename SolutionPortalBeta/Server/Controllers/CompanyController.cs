using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolutionPortalBeta.Server.Models;
using SolutionPortalBeta.Server.Service;
using System;

namespace SolutionPortal.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        [HttpGet]
        public async Task<List<Company>> GetAll()
        {
            return await _companyService.GetAllCompany();
        }
        [HttpGet("{id}")]
        public async Task<Company> Get(int id)
        {
            return await _companyService.GetCompany(id);
        }
        [HttpPost]
        public async Task<Company?> AddCompany([FromBody] Company company)
        {
            return await _companyService.AddCompany(company);
        }
        [HttpDelete("{id}")]
        public async Task<bool> DeleteCompany(int id)
        {
            await _companyService.DeleteCompany(id);
            return true;
        }
        [HttpPut("{id}")]
        public async Task<bool> UpdateCompany(int id, [FromBody] Company Object)
        {
            await _companyService.UpdateCompany(id, Object);
            return true;
        }
    }
}
