﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Performance
{
    public class RestClient
    {
        private static readonly HttpClient _client = new();

        public async Task CallNormal() => await CallRestService("posts", 5001);

        public async Task CallIntercepted() => await CallRestService("interceptedPosts", 5002);

        private async Task CallRestService(string controller, int port)
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var callRest = await _client.GetAsync($"https://localhost:{port}/api/{controller}");
            await callRest.Content.ReadAsStringAsync();
        }
    }
}
