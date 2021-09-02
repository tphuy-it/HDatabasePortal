using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDatabasePortal.Data
{
    public class HDatabasePortalContextFactory : IDesignTimeDbContextFactory<HDatabasePortalContext>
    {
        public HDatabasePortalContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder();
            configuration.SetBasePath(Directory.GetCurrentDirectory());
            configuration.AddJsonFile("appSettings.json");
            var configbuilder = configuration.Build();

            var optionsBuilder = new DbContextOptionsBuilder<HDatabasePortalContext>();
            optionsBuilder.UseSqlServer(configbuilder.GetConnectionString("HDatabasePortalConnection"));
            return new HDatabasePortalContext(optionsBuilder.Options);
        }
    }
}
