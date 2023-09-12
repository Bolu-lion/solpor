using SolutionPortalBeta.Shared;

namespace SolutionPortalBeta.Client.Services.UserComplaintServices
{
    public interface IUserComplaintService
	{
		Task AddComplaint(UserCompliantModel userComplaint);
		Task GetAllComplaint();
		Task<UserCompliantModel> GetComplaint(int id);
		Task<List<UserCompliantModel>> GetComplaintByDate(DateTime date);
	    Task UpdateComplaint(int id, UserCompliantModel userComplaint);
	}
}