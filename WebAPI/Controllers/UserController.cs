using Application.Services;
using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using SocialSiteClassLibrary.Entities;

using Microsoft.AspNetCore.Mvc;

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
        private readonly IBaseService<User> _service;
        private readonly IMapper _mapProfile;

        public UserController(IMapper mapper, IBaseService<User> service)
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

        //[HttpPost(ApiEndpoints.SocialSite.Create)]
        //public async Task<IActionResult> Create([FromBody] CreateUserRequest request, CancellationToken token)
        //{
        //    Console.WriteLine(request.ToJson());

        //    //User tmp = mapProfile.Map<User>(request);
        //    User tmp = new()
        //    {
        //        Banned = request.Banned,
        //        Banner = null,
        //        BannedDate = null,
        //        BannerId = null,
        //        BannedEntities = null,
        //        BanReason = null,

        //        Name = request.Name,
        //        Surname = request.Surname,
        //        Nickname = request.Nickname,
        //        Email = request.Email,
        //        Password = request.Password,
        //        PhoneNumber = request.PhoneNumber,
        //        FriendId = request.FriendId
        //    };
        //    Console.WriteLine(tmp.ToJson());
        //    await service.InsertAsync(tmp, token);
        //    return Ok();
        //}



        
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

    }
}
