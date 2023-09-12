using SolutionPortalBeta.Client.Pages;
using SolutionPortalBeta.Shared;

namespace SolutionPortalBeta.Client.Services.FaqServices
{
    public interface IFaqService
    {
        Task AddFAQ(FAQModel faq);
        Task UpdateFAQ(int id, FAQModel faq);
        Task DeleteFAQ(int id);
        Task GetAllFAQs();
        Task<FAQModel?> GetFAQbyId(int id);
        List<FAQModel> FAQs { get; set; }
    }
}
