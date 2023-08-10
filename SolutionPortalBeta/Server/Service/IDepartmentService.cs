using SolutionPortalBeta.Server.Models;

namespace SolutionPortalBeta.Server.Service
{
    public interface IDepartmentService
    {
        Task<Department> AddDepartment(Department department);
        Task<bool> UpdateDepartment(int id, Department department);
        Task<bool> DeleteDepartment(int id);
        Task<List<Department>> GetAllDepartment();
        Task<Department> GetDepartmentById(int id);
        Task<List<Department>> GetDepartmentsByCompanyId(int id);

    }
}
