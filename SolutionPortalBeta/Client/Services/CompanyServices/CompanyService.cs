using Microsoft.AspNetCore.Components;
using SolutionPortalBeta.Shared;
using System.Net;
using System.Net.Http.Json;

namespace SolutionPortalBeta.Client.Services.CompanyServices
{
    public class CompanyService : ICompanyService
    {

        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;  
        public CompanyService(HttpClient http, NavigationManager navigation) { 

            _http = http;
            _navigationManager = navigation;
         
        }
        public List<CompanyModel> Companies { get; set; } = new List<CompanyModel>();

        public async Task CreateCompany(CompanyModel company)
        {
            await _http.PostAsJsonAsync("api/Company", company);
            _navigationManager.NavigateTo("companies");
        }

        public async Task DeleteCompany(int id)
        {
            var result = await _http.DeleteAsync($"api/Company/{id}");
            _navigationManager.NavigateTo("companies");
        }

        public async Task GetCompanies()
        {
            var result = await _http.GetFromJsonAsync<List<CompanyModel>>("api/Company");
            if (result is not null)
                Companies = result;
        }

        public async Task<CompanyModel?> GetCompanyById(int Id)
        {
            var result = await _http.GetAsync($"api/Company/{Id}");
            if (result.StatusCode == HttpStatusCode.OK)
            {
                return await result.Content.ReadFromJsonAsync<CompanyModel>();
            }
            return null;
        }

        public async Task UpdateCompany(int id, CompanyModel company)
        {
            await _http.PutAsJsonAsync($"api/Company/{id}", company);
            _navigationManager.NavigateTo("admin");
        }
    }
}
