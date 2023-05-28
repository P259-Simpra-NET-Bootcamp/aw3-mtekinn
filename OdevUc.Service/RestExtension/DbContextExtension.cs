using Microsoft.EntityFrameworkCore;
using OdevUc.Data.Context;

namespace OdevUc.Service.RestExtension;


public static class DbContextExtension
{
    public static void AddDbContextExtension(this IServiceCollection services, IConfiguration Configuration)
    {
        var dbType = Configuration.GetConnectionString("DbType");
        if (dbType == "SQL")
        {
            var dbConfig = Configuration.GetConnectionString("MsSqlConnection");
            services.AddDbContext<OdevDbContext>(opts =>
                opts.UseSqlServer(dbConfig));
        }
        else if (dbType== "PostgreSql")
        {
            var dbConfig = Configuration.GetConnectionString("PostgreSqlConnection");
            services.AddDbContext<OdevDbContext>(opts =>
                opts.UseNpgsql(dbConfig));
        }      

    }
}