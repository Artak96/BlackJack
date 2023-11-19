﻿using BlackJack.Core.Abstractions.IRepositories;
using BlackJack.DAL.Context;
using BlackJack.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
namespace BlackJack.API.Extensions
{
    public static class DeviceTrackingServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        }

        public static void AddSQLServerConfig(this WebApplicationBuilder builder)
        {
            string connectionString = builder.Configuration.GetValue<string>("ConnectionStrings:DefaultConnection");
            
            if (!string.IsNullOrEmpty(connectionString))
            {
                builder.Services.AddDbContext<BlackJackDbContext>(options =>
                            options.UseNpgsql(connectionString));
            }

        }
    }
}