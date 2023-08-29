using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolutionPortalBeta.Server.Models;
using SolutionPortalBeta.Server.Service;

namespace SolutionPortalBeta.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {

        //private readonly IDepartmentService _departmentService;

        //public DepartmentController(IDepartmentService departmentService)
        //{
        //    _departmentService = departmentService;
        //}

        //[HttpGet]
        //public async Task<List<Department>> GetAll()
        //{
        //    return await _departmentService.GetAllDepartment();
        //}
        //[HttpGet("{id}")]
        //public async Task<Department> Get(int id)
        //{
        //    return await _departmentService.GetDepartmentById(id);
        //}

        //[HttpPost]
        //public async Task<Department?> AddDepartment([FromBody] Department dept)
        //{
        //    return await _departmentService.AddDepartment(dept);
        //}
        //[HttpDelete("{id}")]
        //public async Task<bool> DeleteDepartment(int id)
        //{
        //    await _departmentService.DeleteDepartment(id);
        //    return true;
        //}
        //[HttpPut("{id}")]
        //public async Task<bool> UpdateDepartment(int id, [FromBody] Department Object)
        //{
        //    await _departmentService.UpdateDepartment(id, Object);
        //    return true;
        //}

        //[HttpGet("{id}")]
        //public async Task<List<Department>> GetDepartmentByCompanyId(int id)
        //{
        //    return await _departmentService.GetDepartmentsByCompanyId(id);
        //}
        
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        [HttpGet]
        public async Task<List<Department>> GetAll()
        {
            return await _departmentService.GetAllDepartment();
        }
        [HttpGet("{id}")]
        public async Task<Department> Get(int id)
        {
            return await _departmentService.GetDepartmentById(id);
        }
        [HttpPost]
        public async Task<Department?> AddDepartment([FromBody] Department department)
        {
            //var createdDepartment = await _departmentService.AddDepartment(department);
            //return Ok(createdDepartment);
            return await _departmentService.AddDepartment(department);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartmentById(int id)
        {
            var department= await _departmentService.GetDepartmentById(id);
            if (department is null)
            {
                return NotFound();
            }
            return Ok(department);
        }

        [HttpGet("company/{companyId}")]
        public async Task<IActionResult> GetDepartmentsByCompanyId(int companyId)
        {
            var departments = await _departmentService.GetDepartmentsByCompanyId(companyId);
            return Ok(departments);
        }
    }
}
