using SolutionPortalBeta.Server.Models;
using SolutionPortalBeta.Shared;

namespace SolutionPortalBeta.Server.Repository
{
    public interface IDepartmentRepository<T>
    {
        public Task<Department> CreateDepartment(T _object);
        public Task<List<Department>> GetDepartments();
        public Task<Department> GetDepartmentById(int Id);
        public Task DeleteDepartment(int Id);
        public Task UpdateDepartment(T _object);
        public Task<List<Department>> GetDepartmentByCompanyId(int CompanyId);

        //public Task<Department> CreateDepartment(Department department);
        //public Task<List<Department>> GetDepartments();
        //public Task<Department> GetDepartmentById(int Id);
        //public Task DeleteDepartment(int Id);
        //public Task UpdateDepartment(Department _object);
        //public Task<List<Department>> GetDepartmentByCompanyId(int CompanyId);
    }
}
