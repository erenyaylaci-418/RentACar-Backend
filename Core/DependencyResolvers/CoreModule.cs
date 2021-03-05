
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Microsoft.Extensions.Caching.Memory;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection servicesCollection)
        {
            servicesCollection.AddMemoryCache();
            servicesCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            servicesCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
        }
    }
}
