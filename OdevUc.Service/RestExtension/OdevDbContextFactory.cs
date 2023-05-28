using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using OdevUc.Data.Context;

namespace OdevUc.Service.RestExtension;

public class OdevContextFactory : IDesignTimeDbContextFactory<OdevDbContext>
{
    public OdevDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<OdevDbContext>();
        optionsBuilder.UseSqlServer("Server=localhost; Database=OdevUc; User Id=SA; PassWord=reallyStrongPwd123; Trusted_Connection=True;");
        
        return new OdevDbContext(optionsBuilder.Options);
    }
}


