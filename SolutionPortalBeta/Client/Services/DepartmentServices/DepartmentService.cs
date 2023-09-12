using Microsoft.AspNetCore.Components;
using SolutionPortalBeta.Shared;
using System.Net;
using System.Net.Http.Json;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SolutionPortalBeta.Client.Services.DepartmentServices
{
    public  class DepartmentService : IDepartmentService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public DepartmentService(HttpClient http, NavigationManager navigation)
        {
            _http = http;
            _navigationManager = navigation;

        }
        public List<DepartmentModel> Departments { get; set; } = new List<DepartmentModel>();

        public async Task<DepartmentModel> GetDepartmentById(int id)
        {
            var result = await _http.GetAsync($"api/department/{id}");
            if (result.StatusCode == HttpStatusCode.OK)
            {
                return await result.Content.ReadFromJsonAsync<DepartmentModel>();
            }
            return null;
        }

        public async Task<List<DepartmentModel>> GetDepartmentsByCompanyId(int id)
        {
            var result = await _http.GetFromJsonAsync<List<DepartmentModel>>($"api/department/company/{id}");
            if (result is not null)
                Departments = result;
            return null;

        }


        public async Task AddDepartment(DepartmentModel department)
        {
            await _http.PostAsJsonAsync("api/department", department);
            //_navigationManager.NavigateTo("companies");
        }

        public async Task DeleteDepartment(int id)
        {
            var result = await _http.DeleteAsync($"api/department/{id}");
            _navigationManager.NavigateTo("admin");
        }

        public async Task GetAllDepartment()
        {
            var result = await _http.GetFromJsonAsync<List<DepartmentModel>>("api/department");
            if (result is not null)
                Departments = result;
        }

        public async Task UpdateDepartment(int id, DepartmentModel department)
        {
            await _http.PutAsJsonAsync($"api/department/{id}", department);
            _navigationManager.NavigateTo("admin");
        }
    }
}
