using Microsoft.EntityFrameworkCore;
using OdevUc.Data.Context;
using OdevUc.Data.Repository;
using OdevUc.Data.Repository.Base;
using OdevUc.Service.RestExtension;


namespace OdevUc.Service;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        var connectionString = "Server=localhost; Database=OdevUc; User Id=SA; PassWord=reallyStrongPwd123; Trusted_Connection=True;";

        services.AddControllers();
        
        services.AddDbContextExtension(Configuration);
        services.AddMapperExtension();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddDbContext<OdevDbContext>(options => options.UseSqlServer(connectionString));


        services.AddScoped<ICategoryRepository, CategoryRepository>();

    }


    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();

        }

        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.DefaultModelsExpandDepth(-1);
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sim Company");
            c.DocumentTitle = "SimApi Company";
        });
        
        


        app.UseHttpsRedirection();

        // add auth 
        app.UseAuthentication();
        app.UseRouting();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
