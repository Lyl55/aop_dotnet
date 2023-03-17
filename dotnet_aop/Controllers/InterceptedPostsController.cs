using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_aop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InterceptedPostsController : ControllerBase
    {
        private readonly IInterceptedPostService _postService;

        public InterceptedPostsController(IInterceptedPostService postService)
        {
            _postService = postService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(string id)
        {
            return Ok(await _postService.GetAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _postService.GetAsync());
        }
    }
}
