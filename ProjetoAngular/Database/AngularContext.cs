using Microsoft.EntityFrameworkCore;
using ProjetoAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAngular.Database
{
    public class AngularContext : DbContext
    {
        public AngularContext(DbContextOptions<AngularContext> dbContext) : base(dbContext)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Review> Reviews { get; set; }
    }
}
