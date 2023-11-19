using BlackJack.BLL.Services;
using BlackJack.Core.Abstractions.IRepositories;
using BlackJack.Core.Abstractions.IServices;
using BlackJack.DAL.Context;
using BlackJack.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
namespace BlackJack.API.Extensions
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<ILogingService, LogingService>();
            services.AddScoped<IBlackJackLogicService, BlackJackLogicService>();
            services.AddScoped<ICardService, CardService>();
            services.AddScoped<IGameService, GameService>();
            services.AddScoped<IHandService, HandService>();
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
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