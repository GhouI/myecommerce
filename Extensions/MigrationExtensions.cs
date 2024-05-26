using Microsoft.EntityFrameworkCore;
using MyEcommerce.Data;

namespace MyEcommerce.Extensions
{
    public static  class MigrationExtensions
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();
            using AppDbContext context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            context.Database.Migrate();
        }
    }
}
