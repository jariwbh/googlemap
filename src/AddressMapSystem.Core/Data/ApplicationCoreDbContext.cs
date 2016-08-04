using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AddressMapSystem.Core.Models;

namespace AddressMapSystem.Core.Data
{
    public class ApplicationCoreDbContext : DbContext
    {
        public ApplicationCoreDbContext(DbContextOptions<ApplicationCoreDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> User { get; set; }
    }
}
