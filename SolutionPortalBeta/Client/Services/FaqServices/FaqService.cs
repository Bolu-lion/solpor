using Microsoft.AspNetCore.Components;
using SolutionPortalBeta.Shared;
using System.Net.Http.Json;
using System.Net;

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
            _navigationManager.NavigateTo("faqlist");
        }

        public async Task DeleteFAQ(int id)
        {
            await _http.DeleteAsync($"api/Faq/{id}");
            _navigationManager.NavigateTo("faqlist");
        }

        public async Task GetAllFAQs()
        {
            var result = await _http.GetFromJsonAsync<List<FAQModel>>("api/Faq");
            if (result is not null) { FAQs = result; }
        }

        public async Task<FAQModel?> GetFAQbyId(int id)
        {
            var result = await _http.GetAsync($"api/Faq/{id}");
            if (result.StatusCode == HttpStatusCode.OK)
            {
                return await result.Content.ReadFromJsonAsync<FAQModel>();
            }
            return null;
        }

        public async Task UpdateFAQ(int id, FAQModel faq)
        {
            await _http.PutAsJsonAsync($"api/Faq/{id}", faq);
            _navigationManager.NavigateTo("admin");
        }
    }
}
