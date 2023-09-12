using Microsoft.AspNetCore.Components;
using SolutionPortalBeta.Shared;
using System.Net;
using System.Net.Http.Json;
namespace SolutionPortalBeta.Client.Services.UserComplaintServices
{
    public class UserComplaintService : IUserComplaintService
    {

        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;  
        public UserComplaintService(HttpClient http, NavigationManager navigation) { 

            _http = http;
            _navigationManager = navigation;
         
        }
        public List<UserCompliantModel> userCompliants {get; set;} = new List<UserCompliantModel>();
        public async Task AddComplaint(UserCompliantModel userComplaint)
        {
            await _http.PostAsJsonAsync("api/UserComplaint", userComplaint);
            _navigationManager.NavigateTo("/");
        }

        public async Task GetAllComplaint()
        {
           var result = await _http.GetFromJsonAsync<List<UserCompliantModel>>("api/UserComplaint");
           if (result is not null)
           {
                userCompliants=  result;
           }
        }

        public async Task<UserCompliantModel?> GetComplaint(int id)
        {
            var result = await _http.GetAsync($"api/UserComplaint/{id}");
            if (result.StatusCode == HttpStatusCode.OK)
            {
                return await result.Content.ReadFromJsonAsync<UserCompliantModel>();
            }
            return null;
        }

        public Task<List<UserCompliantModel>> GetComplaintByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateComplaint(int id, UserCompliantModel userComplaint)
        {
            await _http.PutAsJsonAsync($"api/UserComplaint/{id}", userComplaint);
            _navigationManager.NavigateTo("admin");
        }
    }
}