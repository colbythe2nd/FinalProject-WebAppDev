using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcCoreApplication.Models
{
    public class ReviewsDbContext : DbContext
    {
        public ReviewsDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Reviews> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ReviewsConfig());
        }
    }
}