using SolutionPortalBeta.Server.Models;
using SolutionPortalBeta.Server.Repository;
using System;

namespace SolutionPortalBeta.Server.Service
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository<Company> _company;
        public CompanyService(ICompanyRepository<Company> company) {
            _company = company;
        } 
        public async Task<Company> AddCompany(Company company)
        {
            return await _company.CreateAsync(company);
        }

        public async Task<bool> DeleteCompany(int id)
        {
            await _company.DeleteAsync(id);
            return true;
        }

        public async Task<List<Company>> GetAllCompany()
        {
            return await _company.GetAllAsync();
        }

        public async Task<Company> GetCompany(int id)
        {
            return await _company.GetByIdAsync(id);
        }

        public async Task<bool> UpdateCompany(int id, Company company)
        {
            var data = await _company.GetByIdAsync(id);
            if (data != null)
            {
                data.Name = company.Name;
                await _company.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }
    }
}
