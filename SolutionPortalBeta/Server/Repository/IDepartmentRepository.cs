using SolutionPortalBeta.Server.Models;
using SolutionPortalBeta.Shared;

namespace SolutionPortalBeta.Server.Repository
{
    public interface IDepartmentRepository
    {
        //public Task<Department> CreateAsync(T _object);
        //public Task<List<Department>> GetAllAsync();
        //public Task<Department> GetByIdAsync(int Id);
        //public Task DeleteAsync(int Id);
        //public Task UpdateAsync(T _object);
        //public Task<List<Department>> GetDepartmentByCompanyId(int CompanyId);

        public Task<Department> CreateDepartment(Department department);
        public Task<List<Department>> GetDepartments();
        public Task<Department> GetDepartmentById(int Id);
        public Task DeleteDepartment(int Id);
        public Task UpdateDepartment(Department _object);
        public Task<List<Department>> GetDepartmentByCompanyId(int CompanyId);
    }
}
