using SolutionPortalBeta.Server.Models;
using System;

namespace SolutionPortalBeta.Server.Service
{
    public interface ICompanyService
    {

        Task<Company> AddCompany(Company company);
        Task<bool> UpdateCompany(int id, Company company);
        Task<bool> DeleteCompany(int id);
        Task<List<Company>> GetAllCompany();
        Task<Company> GetCompany(int id);

    }
}
