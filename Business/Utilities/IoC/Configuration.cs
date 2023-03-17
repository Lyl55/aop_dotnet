using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Utilities.IoC
{
    public static class Configuration
    {
        public static IServiceCollection ConfigureBusiness(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IPostService, PostManager>();
            serviceCollection.AddInterceptedScoped<IInterceptedPostService, InterceptedPostManager>();
            return serviceCollection;
        }
    }
}
