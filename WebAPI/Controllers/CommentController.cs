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
    public class CommentController(IMapper mapper, IBaseService<Comment> baseService) : ControllerBase
    {
        private readonly IBaseService<Comment> _service = baseService;
        private readonly IMapper _mapProfile = mapper;

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCommentRequest request, CancellationToken token)
        {
            await _service.InsertAsync(_mapProfile.Map<Comment>(request), token);
            return Ok();
        }

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] CreateCommentRequest request, CancellationToken token)
        {
            await _service.UpdateAsync(_mapProfile.Map<Comment>(request), token);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get(Guid Id, CancellationToken token)
        {
            Comment gotComment = await _service.GetAsync(Id, token);
            if (gotComment == null)
            {
                return NotFound();
            }

            var response = _mapProfile.Map<SingleCommentResponse>(gotComment);

            return response == null ? NotFound() : Ok(response);
        }

    }
}
