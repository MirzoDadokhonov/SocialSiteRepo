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
	public class MessageController(IMapper mapper, IBaseService<Message> baseService) : ControllerBase
	{
		private readonly IBaseService<Message> _service = baseService;
		private readonly IMapper _mapProfile = mapper;

		[HttpPost]
		public async Task<IActionResult> Create([FromBody] CreateMessageRequest request, CancellationToken token)
		{
			await _service.InsertAsync(_mapProfile.Map<Message>(request), token);
			return Ok();
		}

		[Authorize]
		[HttpPut]
		public async Task<IActionResult> Update([FromBody] CreateMessageRequest request, CancellationToken token)
		{
			await _service.UpdateAsync(_mapProfile.Map<Message>(request), token);
			return Ok();
		}

		[HttpGet]
		public async Task<IActionResult> Get(Guid Id, CancellationToken token)
		{
			Message gotComment = await _service.GetAsync(Id, token);
			if (gotComment == null)
			{
				return NotFound();
			}

			var response = _mapProfile.Map<SingleMessageResponse>(gotComment);

			return response == null ? NotFound() : Ok(response);
		}

	}
}
