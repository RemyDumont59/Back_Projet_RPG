using Back_Projet_RPG.Data;
using Back_Projet_RPG.Models;
using Back_Projet_RPG.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.VisualBasic;
using System.Security.Claims;
using System.Text;

namespace Back_Projet_RPG.Extensions
{
    public static class DependencyInjectionExtension
    {
        public static void InjectDependancies(this WebApplicationBuilder builder)
        {

            builder.Services.AddControllers();
            builder.AddDatabase();
            builder.AddRepositories();
            builder.AddCors();


        }

        private static void AddDatabase(this WebApplicationBuilder builder)
        {

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer(connectionString);
            });
        }

        private static void AddRepositories(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IRepository<Player>, PlayerRepository>();
            builder.Services.AddScoped<IRepository<Enemy>, EnemyRepository>();
        }

        private static void AddCors(this WebApplicationBuilder builder)
        {
            builder.Services.AddCors(option =>
            {
                option.AddPolicy("allConnections", option =>
                {
                    option.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });
        }

    }

}
