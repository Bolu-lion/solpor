using SolutionPortalBeta.Server.Models;
using SolutionPortalBeta.Server.Repository;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SolutionPortalBeta.Server.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<Department> AddDepartment(Department department)
        {
            return await _departmentRepository.CreateDepartment(department);
        }

        public async Task<bool> DeleteDepartment(int id)
        {
            await _departmentRepository.DeleteDepartment(id);
            return true;
        }

        public async Task<List<Department>> GetAllDepartment()
        {
            return await _departmentRepository.GetDepartments();
        }

        public async Task<Department> GetDepartmentById(int id)
        {
            return await _departmentRepository.GetDepartmentById(id);
        }

        public async Task<List<Department>> GetDepartmentsByCompanyId(int id)
        {
            return await _departmentRepository.GetDepartmentByCompanyId(id);
        }

        public async Task<bool> UpdateDepartment(int id, Department department)
        {
            var data = await _departmentRepository.GetDepartmentById(id);
            if(data != null)
            {
                data.Name = department.Name;
                data.UserName = department.UserName;
                data.Company = department.Company;
                await _departmentRepository.UpdateDepartment(data);
                return true;
            }
            else { return false; }
        }

        //private readonly IDepartmentRepository<Department> _department;
        //public DepartmentService(IDepartmentRepository<Department> department)
        //{
        //    _department = department;
        //}
        //public async Task<Department> AddDepartment(Department department)
        //{
        //    return await _department.CreateAsync(department);
        //}

        //public async Task<bool> DeleteDepartment(int id)
        //{
        //    await _department.DeleteAsync(id);
        //    return true;
        //}

        //public async Task<List<Department>> GetAllDepartment()
        //{
        //    return await _department.GetAllAsync();
        //}

        //public async Task<Department> GetDepartmentById(int id)
        //{
        //    return await _department.GetByIdAsync(id);
        //}

        //public async Task<List<Department>> GetDepartmentsByCompanyId(int id)
        //{
        //  return await _department.GetByCompanyId(id);
        //}

        //public async Task<bool> UpdateDepartment(int id, Department department)
        //{
        //    var data = await _department.GetByIdAsync(id);
        //    if (data != null)
        //    {
        //        data.Name = department.Name;
        //        data.UserName = department.UserName;
        //        data.Company = department.Company;
        //        await _department.UpdateAsync(data);
        //        return true;
        //    }
        //    else
        //        return false;
        //}
    }
}
