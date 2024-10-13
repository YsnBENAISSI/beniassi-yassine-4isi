using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using benaissi-yassine-4isi;

namespace data
{
    class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
