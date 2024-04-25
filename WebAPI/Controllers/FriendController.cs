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
	public class FriendController(IMapper mapper, IBaseService<Friend> baseService) : ControllerBase
	{
		private readonly IBaseService<Friend> _service = baseService;
		private readonly IMapper _mapProfile = mapper;

		[HttpPost]
		public async Task<IActionResult> Create([FromBody] CreateFriendRequest request, CancellationToken token)
		{
			await _service.InsertAsync(_mapProfile.Map<Friend>(request), token);
			return Ok();
		}

		[Authorize]
		[HttpPut]
		public async Task<IActionResult> Update([FromBody] CreateFriendRequest request, CancellationToken token)
		{
			await _service.UpdateAsync(_mapProfile.Map<Friend>(request), token);
			return Ok();
		}

		[HttpGet]
		public async Task<IActionResult> Get(Guid Id, CancellationToken token)
		{
			Friend gotComment = await _service.GetAsync(Id, token);
			if (gotComment == null)
			{
				return NotFound();
			}

			var response = _mapProfile.Map<SingleFriendResponse>(gotComment);

			return response == null ? NotFound() : Ok(response);
		}

	}
}
