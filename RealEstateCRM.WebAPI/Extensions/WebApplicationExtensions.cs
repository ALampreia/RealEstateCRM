using Microsoft.EntityFrameworkCore;
using RealEstateCRM.Data.Context;

namespace RealEstateCRM.WebAPI.Extensions
{
    public static class WebApplicationExtensions
    {
        public static void EnsureDataBaseMigration(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var services = scope.ServiceProvider;

            try
            {
                var context = services.GetRequiredService<RealEstateCrmDbContext>();
                context.Database.Migrate();
            }
            catch
            {

            }
        }
    }
}
