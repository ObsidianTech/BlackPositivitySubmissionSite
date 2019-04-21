using BlackPositivity.Services.Abstractions.RepoAbstractions;
using BlackPositivity.Services.Abstractions.ServiceAbstractions;
using BlackPositivity.Services.Repositories;
using BlackPositivity.Services.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackPositivitySubmissionSite.Extentions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplicationExtensions(this IServiceCollection services)
        {
            services.AddScoped<IQuoteService, BlackPositivityQuoteService>();
            services.AddScoped<IQuoteRepository, BlackPositivityQuoteRepository>();
            return services;
        }
    }
}
