using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Watch_IoC
{
    public class DependencyInjection
    {
        private readonly IConfiguration _configuration;
        public DependencyInjection(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void InjectDependencies(IServiceCollection services)
        {
            //Add In-Memory Cache Service
            services.AddMemoryCache();
            //Add DbContext service

            //Add AutoMapper service
            
            //Add other transient,scoped,singleton services here
        }
    }
}
