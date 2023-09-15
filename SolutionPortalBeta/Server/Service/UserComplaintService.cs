 using SolutionPortalBeta.Server.Models;
using SolutionPortalBeta.Server.Repository;
using System;

namespace SolutionPortalBeta.Server.Service
{
	public class UserComplaintService : IUserComplaintService
	{
		private readonly IRepository<UserComplaint> _userComplaint;
		public UserComplaintService(IRepository<UserComplaint> userComplaint)
		{
			_userComplaint = userComplaint;
		}
		
		public async Task<UserComplaint> AddComplaint(UserComplaint userComplaint)
		{
			return await _userComplaint.CreateAsync(userComplaint);
		}

		public async Task<List<UserComplaint>> GetAllComplaint()
		{
			return await _userComplaint.GetAllAsync();
		}

		public async Task<UserComplaint> GetComplaint(int id)
		{
			return await _userComplaint.GetByIdAsync(id);
		}

        public async Task<List<UserComplaint>> GetComplaintByDate(DateTime date)
        {
            return await _userComplaint.GetByDateAsync(date);
        }

		public async Task<bool> UpdateComplaint(int id, UserComplaint userComplaint)
        {
            var data = await _userComplaint.GetByIdAsync(id);
            if (data != null)
            {
                data.Response = userComplaint.Response;
				userComplaint.IsCompleted = true;
				data.IsCompleted = userComplaint.IsCompleted;
                await _userComplaint.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }

    }
}
