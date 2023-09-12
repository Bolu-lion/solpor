using Microsoft.AspNetCore.Components;
using SolutionPortalBeta.Shared;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace SolutionPortalBeta.Client.Services.AttachmentServices
{
    public class AttachmentService : IAttachmentService
    {
        private readonly HttpClient _httpClient;
        private readonly NavigationManager _navigationManager;
        public AttachmentService(HttpClient httpClient, NavigationManager navigationManager) {
            _httpClient = httpClient;
            _navigationManager = navigationManager;
        }
        public List<AttachementModel> Attachments{ get; set; }= new List<AttachementModel>();
        public async Task<AttachementModel> AddAttachment(AttachementModel attachment)
        {
            await _httpClient.PostAsJsonAsync("api/attachment", attachment);
            return null;
        }

        public async Task<List<AttachementModel>> GetAllAttachments()
        {
            var result = await _httpClient.GetFromJsonAsync<List<AttachementModel>>("api/attachment");
            if (result is not null) { Attachments = result; }
            return null;
        }

        public async Task<AttachementModel> GetAttachment(int id)
        {
            var result = await _httpClient.GetAsync($"api/attachment/{id}");
            if(result.IsSuccessStatusCode) { return await result.Content.ReadFromJsonAsync<AttachementModel>(); }
            return null;
        }

        public async Task<List<AttachementModel>> GetAttachmentByCompliantId(int ComplaintId)
        {
            var result = await _httpClient.GetFromJsonAsync<List<AttachementModel>>($"api/attachment/complaint/{ComplaintId}");
            if (result is not null)
                Attachments = result;
            return null;
        }
    }
}
