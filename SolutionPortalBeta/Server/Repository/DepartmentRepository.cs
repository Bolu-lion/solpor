using Microsoft.EntityFrameworkCore;
using SolutionPortalBeta.Server.AppDbContext;
using SolutionPortalBeta.Server.Models;

namespace SolutionPortalBeta.Server.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public DepartmentRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Department> CreateDepartment(Department department)
        {
            _dbContext.Departments.Add(department);
            await _dbContext.SaveChangesAsync();
            return department;
        }

        public async Task DeleteDepartment(int Id)
        {
            var data = _dbContext.Departments.FirstOrDefault(x => x.Id == Id);
            _dbContext.Remove(data);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Department>> GetDepartmentByCompanyId(int CompanyId)
        {
            return await _dbContext.Departments.Where(d=>d.CompanyId == CompanyId).ToListAsync();
        }

        public async Task<Department> GetDepartmentById(int Id)
        {
            return await _dbContext.Departments.FindAsync(Id);
        }

        public async Task<List<Department>> GetDepartments()
        {
            return await _dbContext.Departments.ToListAsync();
        }

        public async Task UpdateDepartment(Department _object)
        {
            _dbContext.Departments.Update(_object);
            await _dbContext.SaveChangesAsync();
        }
    }
    //ApplicationDbContext _dbContext;
    //public DepartmentRepository(ApplicationDbContext dbcontext)
    //{
    //    _dbContext = dbcontext;
    //}
    //public async Task<Department> CreateAsync(Department _object)
    //{
    //    var obj = await _dbContext.Departments.AddAsync(_object);
    //    _dbContext.SaveChanges();
    //    return obj.Entity;
    //}

    //public async Task DeleteAsync(int Id)
    //{
    //    var data = _dbContext.Departments.FirstOrDefault(x => x.Id == Id);
    //    _dbContext.Remove(data);
    //    await _dbContext.SaveChangesAsync();
    //}

    //public async Task<List<Department>> GetAllAsync()
    //{
    //    return await _dbContext.Departments.ToListAsync();
    //}

    //public async Task<List<Department>> GetByCompanyId(int CompanyId)
    //{
    //    return await _dbContext.Departments.Where(x => x.CompanyId == CompanyId).ToListAsync();
    //}

    //public async Task<Department> GetByIdAsync(int Id)
    //{
    //    return await _dbContext.Departments.FirstOrDefaultAsync(x => x.Id == Id);
    //}

    //public async Task UpdateAsync(Department _object)
    //{
    //    _dbContext.Departments.Update(_object);
    //    await _dbContext.SaveChangesAsync();
    //}


}

