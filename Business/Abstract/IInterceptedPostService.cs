using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Business.Abstract
{
    public interface IInterceptedPostService
    {
        Task<Post> GetAsync(string id);
        Task<List<Post>> GetAsync();
    }
}
