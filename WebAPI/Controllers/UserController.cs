using Application.Services;
using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Microsoft.AspNetCore.Mvc;
using NuGet.Common;
using SocialSiteClassLibrary.Entities;

namespace WebAPI.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    //public class UserController(IBaseService<User> service, IMapper mapProfile) : ControllerBase
    //{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly UserService _service;
        private readonly IMapper _mapProfile;

        public UserController(IMapper mapper, UserService service)
        {
            _service = service;
            _mapProfile = mapper;
        }
        [HttpPost(ApiEndpoints.Methods.Create)]
        public async Task<IActionResult> Create([FromBody] CreateUserRequest request, CancellationToken token)
        {
            var user = _mapProfile.Map<User>(request);

            var response = await _service.InsertAsync(user, token);
            return CreatedAtAction(nameof(Create), new { id = response.Id }, response);
        }

        
        [HttpPut(ApiEndpoints.Methods.Update)]
        public async Task<IActionResult> Update([FromBody] CreateUserRequest request, CancellationToken token)
        {
            if (request == null)
            {
                return BadRequest("Invalid request data.");
            }

            User user = _mapProfile.Map<User>(request);

            await _service.UpdateAsync(user, token);

            var response = _mapProfile.Map<User>(user);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpGet(ApiEndpoints.Methods.Get)]
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

        [HttpGet(ApiEndpoints.Methods.GetAll)]
        public async Task<IActionResult> GetAll(CancellationToken token)
        {
            var gotUsers = await _service.GetAllAsync(token);

            var response = new GetAllUsersResponse()
            {
                Items = _mapProfile.Map<IEnumerable<SingleUserResponse>>(gotUsers)
            };

            return Ok(response);
        }
        /*
        [HttpGet]
        public async Task<IActionResult> GetFiltered(CancellationToken token, int postMessageOrLike = 3, int? top = null)
        {
            var gotUsers = await _service.GetFilteredAsync(token, postMessageOrLike, top);

            var response = new GetAllUsersResponse()
            {
                Items = _mapProfile.Map<IEnumerable<SingleUserResponse>>(gotUsers)
            };

            return Ok(response); 
            //List<User> topUsers = await _service.GetAllAsync().Wh

        }*/
    }
}
