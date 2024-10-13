using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace users_manage_data
{
    internal class DbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        private readonly string sconn = "Server=DESKTOP-FMBNIC2\\SQLEXPRESS;Database=ParthenonSocial;TRUSTED_CONNECTION=TRUE;TrustServerCertificate=True;";

        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseSqlServer(sconn);

            return new AppDbContext(optionsBuilder.Options);
        }

        AppDbContext IDesignTimeDbContextFactory<AppDbContext>.CreateDbContext(string[] args)
        {
            throw new NotImplementedException();
        }
    }
}
