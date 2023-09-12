using SolutionPortalBeta.Server.Models;
using System;

namespace SolutionPortalBeta.Server.Service
{
	public interface IUserComplaintService
	{
		Task<UserComplaint> AddComplaint(UserComplaint userComplaint);
		Task<List<UserComplaint>> GetAllComplaint();
		Task<UserComplaint> GetComplaint(int id);
		Task<List<UserComplaint>> GetComplaintByDate(DateTime date);
	    Task<bool> UpdateComplaint(int id, UserComplaint userComplaint);
	}
}
