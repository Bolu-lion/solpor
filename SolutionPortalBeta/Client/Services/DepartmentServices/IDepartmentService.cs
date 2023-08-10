using SolutionPortalBeta.Shared;

namespace SolutionPortalBeta.Client.Services.DepartmentServices
{
    public interface IDepartmentService
    {
        List<DepartmentModel> Departments { get; set; }
        Task AddDepartment(DepartmentModel department);
        Task UpdateDepartment(int id, DepartmentModel department);
        Task DeleteDepartment(int id);
        Task GetAllDepartment();
        Task<DepartmentModel> GetDepartmentById(int id);
        Task<List<DepartmentModel>> GetDepartmentsByCompanyId(int id);
    }
}
