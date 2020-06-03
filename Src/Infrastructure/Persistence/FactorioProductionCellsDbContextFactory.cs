using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FactorioProductionCells.Infrastructure.Persistence
{
    public class FactorioProductionCellsDbContextFactory : DesignTimeDbContextFactoryBase<FactorioProductionCellsDbContext>
    {
        /*
        public FactorioProductionCellsDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FactorioProductionCellsDbContext>();
            // TODO: "dotnet ef migrations add" is remarkably stupid, and believes that we need a connection string in order to generate a migration. Since this is a class library, we
            // won't be able to read our connection string from the environment at generation time, so it throws a fit here. Fortunately, this factory should only ever be used by
            // "ef migrations", so we can just trick it into thinking we have one (it won't accept null or empty string). There's probably a better way to do this.
            optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("POSTGRES_CONNECTION_STRING") ?? "X");

            return new FactorioProductionCellsDbContext(optionsBuilder.Options);
        }
        */
        
        protected override FactorioProductionCellsDbContext CreateNewInstance(DbContextOptions<FactorioProductionCellsDbContext> options)
        {
            return new FactorioProductionCellsDbContext(options);
        }
    }
}