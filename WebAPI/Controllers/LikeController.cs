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
	public class LikeController(IMapper mapper, IBaseService<Like> baseService) : ControllerBase
	{
		private readonly IBaseService<Like> _service = baseService;
		private readonly IMapper _mapProfile = mapper;

		[HttpPost]
		public async Task<IActionResult> Create([FromBody] CreateLikeRequest request, CancellationToken token)
		{
			await _service.InsertAsync(_mapProfile.Map<Like>(request), token);
			return Ok();
		}


		[HttpPut]
		public async Task<IActionResult> Update([FromBody] CreateLikeRequest request, CancellationToken token)
		{
			await _service.UpdateAsync(_mapProfile.Map<Like>(request), token);
			return Ok();
		}

		[HttpGet]
		public async Task<IActionResult> Get(Guid Id, CancellationToken token)
		{
			Like gotComment = await _service.GetAsync(Id, token);
			if (gotComment == null)
			{
				return NotFound();
			}

			var response = _mapProfile.Map<SingleLikeResponse>(gotComment);

			return response == null ? NotFound() : Ok(response);
		}

	}
}
