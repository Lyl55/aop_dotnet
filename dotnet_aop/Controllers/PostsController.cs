using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_aop.Controllers
{
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostsController(IPostService postService)
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
