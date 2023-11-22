using Back_Projet_RPG.Data;
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

        }

        private static void AddDatabase(this WebApplicationBuilder builder)
        {

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
        }

    }

}
