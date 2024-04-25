using Application.Services;
using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using SocialSiteClassLibrary.Entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly UserService _service;
        private readonly IMapper _mapProfile;

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserRequest request, CancellationToken token)
        {
            Console.WriteLine(request.ToJson());
            User tmp = _mapProfile.Map<User>(request);
            await _service.InsertAsync(tmp, token);
            return Ok();
        }

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] CreateUserRequest request, CancellationToken token)
        {
            await _service.UpdateAsync(_mapProfile.Map<User>(request), token);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get(Guid Id, CancellationToken token)
        {
            User gotUser = await _service.GetAsync(Id, token);
            if (gotUser == null)
            {
                return NotFound();
            }

            var response = _mapProfile.Map<SingleUserResponse>(gotUser);

            return response == null ? NotFound() : Ok(response);
        }
    }
}
