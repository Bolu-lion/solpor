using Microsoft.AspNetCore.Components;
using SolutionPortalBeta.Shared;
using System.Net.Http.Json;

namespace SolutionPortalBeta.Client.Services.FaqServices
{
    public class FaqService : IFaqService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public FaqService(HttpClient http, NavigationManager nav)
        {
            _http = http;
            _navigationManager = nav;
        }

        public List<FAQModel> FAQs { get; set; } = new List<FAQModel>();

        public async Task AddFAQ(FAQModel faq)
        {
            await _http.PostAsJsonAsync("api/Faq", faq);
            _navigationManager.NavigateTo("companies");
        }

        public Task DeleteFAQ(int id)
        {
            throw new NotImplementedException();
        }

        public async Task GetAllFAQs()
        {
            var result = await _http.GetFromJsonAsync<List<FAQModel>>("api/Faq");
            if (result is not null) { FAQs = result; }
        }

        public Task<FAQModel?> GetFAQbyId(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateFAQ(int id, FAQModel faq)
        {
            throw new NotImplementedException();
        }
    }
}
