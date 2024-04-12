using Application.Common.Mapping;
using Application.Services;
using AutoMapper;
using Contracts.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialSiteClassLibrary.Entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly CommentService _service;
        private readonly IMapper _mapProfile;

        [HttpPost]
        public Task<Comment> Create([FromBody] CreateCommentRequest request, CancellationToken token)
        {
            return _service.InsertAsync(_mapProfile.Map<Comment>(request), token);
        }
    }
}
