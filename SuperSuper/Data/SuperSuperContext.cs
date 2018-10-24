using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SuperSuper.Models;

namespace SuperSuper.Models
{
    public class SuperSuperContext : DbContext
    {
        public SuperSuperContext (DbContextOptions<SuperSuperContext> options)
            : base(options)
        {
        }

        public DbSet<SuperSuper.Models.Product> Product { get; set; }

        public DbSet<SuperSuper.Models.Customer> Customer { get; set; }

        public DbSet<SuperSuper.Models.Purcheses> Purcheses { get; set; }

        public DbSet<SuperSuper.Models.Admin> Admin { get; set; }

        public DbSet<SuperSuper.Models.SuperUser> SuperUser { get; set; }
    }
}
