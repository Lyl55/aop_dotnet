﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Entities;
using Business.Utilities.Http;
using Core.Aspects.Logging;
using Core.Aspects.Performance;

namespace Business.Concrete
{
    public class InterceptedPostManager : IInterceptedPostService
    {
        private const string _url = "https://jsonplaceholder.typicode.com/posts/";
        public async Task<Post> GetAsync(string id) => await _url.GetAsync<Post>(id);

        [Performance(Interval = 0)]
        [Log]
        public async Task<List<Post>> GetAsync() => await _url.GetAsync<List<Post>>();
    }
}
