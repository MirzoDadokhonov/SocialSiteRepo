using Application.Services;
using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SocialSiteClassLibrary.Entities;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GroupMemberController(IMapper mapper, IBaseService<GroupMember> baseService) : ControllerBase
	{
		private readonly IBaseService<GroupMember> _service = baseService;
		private readonly IMapper _mapProfile = mapper;

		[HttpPost]
		public async Task<IActionResult> Create([FromBody] CreateGroupMemberRequest request, CancellationToken token)
		{
			await _service.InsertAsync(_mapProfile.Map<GroupMember>(request), token);
			return Ok();
		}


		[HttpPut]
		public async Task<IActionResult> Update([FromBody] CreateGroupMemberRequest request, CancellationToken token)
		{
			await _service.UpdateAsync(_mapProfile.Map<GroupMember>(request), token);
			return Ok();
		}

		[HttpGet]
		public async Task<IActionResult> Get(Guid Id, CancellationToken token)
		{
			GroupMember gotComment = await _service.GetAsync(Id, token);
			if (gotComment == null)
			{
				return NotFound();
			}

			var response = _mapProfile.Map<SingleGroupMemberResponse>(gotComment);

			return response == null ? NotFound() : Ok(response);
		}

	}
}
