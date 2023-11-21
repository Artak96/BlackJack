using AutoMapper;
using BlackJack.BLL.Services;
using BlackJack.Core.Abstractions.IRepositories;
using BlackJack.Core.Abstractions.IServices;
using BlackJack.DAL.Context;
using BlackJack.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.BLL.Extensions
{
    public static class BllServicesRegistration
    {
        public static IServiceCollection BllServicesRegister(this IServiceCollection services, IConfiguration configuration)
        {
            AddSQLServerConfig(services, configuration);

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<ILogingService, LogingService>();
            services.AddScoped<IBlackJackLogicService, BlackJackLogicService>();
            services.AddScoped<ICardService, CardService>();
            services.AddScoped<IGameService, GameService>();
            services.AddScoped<IHandService, HandService>();
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
        public static void AddSQLServerConfig(IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");

            if (!string.IsNullOrEmpty(connectionString))
            {
                services.AddDbContext<BlackJackDbContext>(options =>
                            options.UseNpgsql(connectionString));
            }

        }
    }
}
