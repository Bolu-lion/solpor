using SolutionPortalBeta.Shared;

namespace SolutionPortalBeta.Client.Services.CompanyServices
{
    public interface ICompanyService
    {
        List<CompanyModel> Companies { get; set; }
        Task GetCompanies();
        Task<CompanyModel?> GetCompanyById(int Id);
        Task CreateCompany(CompanyModel company);
        Task UpdateCompany(int id, CompanyModel company);
        Task DeleteCompany(int id);
    }
}
