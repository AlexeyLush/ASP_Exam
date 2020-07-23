using Edu.Application.Implementation;
using Edu.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Edu.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IApplicationStudentRepository, ApplicationStudentRepository>();
            return services;
        }
    }
}
