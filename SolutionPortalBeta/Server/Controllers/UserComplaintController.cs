using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolutionPortalBeta.Server.Models;
using SolutionPortalBeta.Server.Service;
using System;

namespace SolutionPortalBeta.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserComplaintController : ControllerBase
	{
		private readonly IUserComplaintService _userComplaintService;
		public UserComplaintController(IUserComplaintService userComplaintService)
		{
			_userComplaintService = userComplaintService;
		}
		[HttpGet]
		public async Task<List<UserComplaint>> GetAll()
		{
			return await _userComplaintService.GetAllComplaint();
		}
		[HttpGet("{id}")]
		public async Task<UserComplaint> Get(int id)
		{
			return await _userComplaintService.GetComplaint(id);
		}
		[HttpPost]
		public async Task<UserComplaint> AddComplaint([FromBody] UserComplaint userComplaint)
		{
			return await _userComplaintService.AddComplaint(userComplaint);
		}
		[HttpGet("{date}")]
		public async Task<List<UserComplaint>>GetByDate(string date)
		{
			return await _userComplaintService.GetComplaintByDate(DateTime.Parse(date));
		}
		[HttpPut("{id}")]
		public async Task<bool> UpdateComplaint(int id, [FromBody] UserComplaint userComplaint)
		{
			await _userComplaintService.UpdateComplaint(id, userComplaint);
			return true;
		}
	}
}
