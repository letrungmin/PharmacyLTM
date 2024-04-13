using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PharmacyLTM.Data.EF
{
    public class PharmacyLTMDbContextFactory : IDesignTimeDbContextFactory<PharmacyLTMDbContext>
    {
        public PharmacyLTMDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var ConnectionStrings = configuration.GetConnectionString("PharmacyLTMDb");

            var optionsBuilder = new DbContextOptionsBuilder<PharmacyLTMDbContext>();
            optionsBuilder.UseSqlServer(ConnectionStrings);

            return new PharmacyLTMDbContext(optionsBuilder.Options);
        }
    }
}
